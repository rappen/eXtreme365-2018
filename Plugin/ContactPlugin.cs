using System;
using System.Linq;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Plugin
{
    public class ContactPlugin : PluginBase
    {
        #region Constructor/Configuration
        private string _secureConfig = null;
        private string _unsecureConfig = null;

        public ContactPlugin(string unsecure, string secureConfig)
            : base(typeof(ContactPlugin))
        {
            _secureConfig = secureConfig;
            _unsecureConfig = unsecure;
        }
        #endregion

        protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
        {

        }
    }
}