using DLaB.Xrm;
using JonasPluginBase;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    public static class SDKExtensions
    {
        #region LocalPluginContext based extensions

        public static Entity GetParent(this Entity entity, LocalPluginContext context, string lookupattribute, params string[] attributes)
        {
            if (!entity.Contains(lookupattribute))
            {
                context.Trace($"Missing lookup attribute {lookupattribute}");
                return null;
            }
            if (!(entity[lookupattribute] is EntityReference parentref))
            {
                context.Trace($"{lookupattribute} is not EntityReference");
                return null;
            }
            return context.OrganizationService.Retrieve(parentref.LogicalName, parentref.Id, new ColumnSet(attributes));
        }

        public static IEnumerable<Entity> GetChildren(this Entity entity, LocalPluginContext context, string childname, string lookupattribute, params string[] attributes)
        {
            var qx = QueryExpressionFactory.Create(childname, true, new ColumnSet(attributes), false, new object[] { lookupattribute, entity.Id });
            return context.RetrieveMultiple(qx).Entities;
        }

        public static EntityCollection RetrieveMultiple(this LocalPluginContext local, QueryBase query)
        {
            local.Trace($"Internal RM {query.GetType()}");
            if (query is QueryExpression qx)
            {
                local.Trace($"Querying entity {qx.EntityName}");
                local.Trace($"Attributes: {string.Join(", ", qx.ColumnSet.Columns)}");
            }
            var sw = Stopwatch.StartNew();
            var result = local.OrganizationService.RetrieveMultiple(query);
            sw.Stop();
            local.Trace($"Returning {result.Entities.Count} records after {sw.ElapsedMilliseconds} ms");
            return result;
        }

        public static Entity Retrieve(this LocalPluginContext local, string entityname, Guid id, ColumnSet columns)
        {
            local.Trace($"Internal R {entityname}, {id}");
            var sw = Stopwatch.StartNew();
            var result = local.OrganizationService.Retrieve(entityname, id, columns);
            sw.Stop();
            local.Trace($"Returning record after {sw.ElapsedMilliseconds} ms");
            return result;
        }

        #endregion LocalPluginContext based extensions

        #region JonasPluginBag based extensions

        public static Entity GetParent(this Entity entity, JonasPluginBag bag, string lookupattribute, params string[] attributes)
        {
            if (!entity.Contains(lookupattribute))
            {
                bag.Trace($"Missing lookup attribute {lookupattribute}");
                return null;
            }
            if (!(entity[lookupattribute] is EntityReference parentref))
            {
                bag.Trace($"{lookupattribute} is not EntityReference");
                return null;
            }
            return bag.Service.Retrieve(parentref.LogicalName, parentref.Id, new ColumnSet(attributes));
        }

        public static IEnumerable<Entity> GetChildren(this Entity entity, JonasPluginBag bag, string childname, string lookupattribute, params string[] attributes)
        {
            var qx = QueryExpressionFactory.Create(childname, true, new ColumnSet(attributes), false, new object[] { lookupattribute, entity.Id });
            return bag.Service.RetrieveMultiple(qx).Entities;
        }

        public static Guid Save(this Entity entity, JonasPluginBag bag)
        {
            var result = entity.Id;
            var sw = Stopwatch.StartNew();
            if (entity.Id.Equals(Guid.Empty))
            {
                bag.Trace("Saving entity");
                result = bag.Service.Create(entity);
            }
            else
            {
                bag.Trace("Updating entity");
                bag.Service.Update(entity);
            }
            sw.Stop();
            bag.Trace($"Saved record in {sw.ElapsedMilliseconds} ms");
            return result;
        }

        #endregion JonasPluginBag based extensions

        public static Entity PostImage(this IPluginExecutionContext context)
        {
            return context.PostEntityImages.Select(i => i.Value).FirstOrDefault();
        }
    }
}
