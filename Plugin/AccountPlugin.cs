using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JonasPluginBase;
using Microsoft.Xrm.Sdk;

namespace Plugin
{
    public class AccountPlugin : JonasPluginBase.JonasPluginBase
    {
        public override void Execute(JonasPluginBag bag)
        {
            if (bag == null)
                throw new ArgumentNullException(nameof(bag));

            bag.Trace("Hello world");

            if (bag.PluginContext.PrimaryEntityName != "contact")
            {
                bag.Trace($"Triggered incorrectly for {bag.PluginContext.PrimaryEntityName}");
                return;
            }
            bag.Trace($"PreImage count: {bag.PluginContext.PreEntityImages.Count}");
            bag.Trace($"PostImage count: {bag.PluginContext.PostEntityImages.Count}");
            if (!(bag.PostImage is Entity contact))
            {
                return;
            }
            bag.Trace($"Entity is {contact.LogicalName} {contact.Id}");

            if (!(contact.GetParent(bag, Contact.CompanyName, Account.PrimaryName, Account.AccountNumber) is Entity account))
            {
                return;
            }
            bag.Trace($"Parent is {account.LogicalName} {account[Account.PrimaryName]}");

            var cases = account.GetChildren(bag, Case.EntityName, Case.Customer, Case.Subject, Case.CaseNumber);
            bag.Trace($"Found {cases.Count()} cases: {string.Join(", ", cases.Select(c => c[Case.CaseNumber]))}");

            foreach (var acase in cases)
            {
                acase[Case.Description] = null;
                acase[Case.Satisfaction] = new OptionSetValue((int)Case.Satisfaction_OptionSet.VerySatisfied);
                acase.Save(bag);
            }
        }
    }
}
