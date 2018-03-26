using System;
using System.Linq;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Plugin
{
    public class ContactPlugin1 : PluginBase
    {
        #region Constructor/Configuration
        private string _secureConfig = null;
        private string _unsecureConfig = null;

        public ContactPlugin1(string unsecure, string secureConfig)
            : base(typeof(ContactPlugin1))
        {
            _secureConfig = secureConfig;
            _unsecureConfig = unsecure;
        }
        #endregion

        protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
        {
            if (localContext == null)
                throw new ArgumentNullException(nameof(localContext));

            localContext.Trace("Hello world");

            if (localContext.PluginExecutionContext.PrimaryEntityName != "contact")
            {
                localContext.Trace($"Triggered incorrectly for {localContext.PluginExecutionContext.PrimaryEntityName}");
                return;
            }
            localContext.Trace($"PreImage count: {localContext.PluginExecutionContext.PreEntityImages.Count}");
            localContext.Trace($"PostImage count: {localContext.PluginExecutionContext.PostEntityImages.Count}");
            if (!(localContext.PluginExecutionContext.PostImage() is Entity contact))
            {
                return;
            }
            localContext.Trace($"Entity is {contact.LogicalName} {contact.Id}");

            if (!(contact.GetParent(localContext, Contact.CompanyName, Account.PrimaryName, Account.AccountNumber) is Entity account))
            {
                return;
            }
            localContext.Trace($"Parent is {account.LogicalName} {account[Account.PrimaryName]}");

            var cases = account.GetChildren(localContext, Case.EntityName, Case.Customer, Case.Subject, Case.CaseNumber);
            localContext.Trace($"Found {cases.Count()} cases: {string.Join(", ", cases.Select(c => c[Case.CaseNumber]))}");

            foreach (var acase in cases)
            {
                acase[Case.Description] = null;
                acase[Case.Satisfaction] = new OptionSetValue((int)Case.Satisfaction_OptionSet.VerySatisfied);
                localContext.OrganizationService.Update(acase);
            }
        }
    }
}