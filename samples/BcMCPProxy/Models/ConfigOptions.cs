namespace BcMCPProxy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Net.WebRequestMethods;

    public  class ConfigOptions
    {
        public string ServerName = "BcMCPProxy";
        public string ServerVersion = "1.0.0";

        public string TenantId { get; set; } = "1e2b5da5-7338-4453-ae09-85012fdd49fc";

        public string ClientId { get; set; } = "110097e2-0df2-4fd4-bf30-cf33276bd0bb";

        public string TokenScope { get; set; } = "https://api.businesscentral.dynamics.com/.default";

        public string Url { get; set; } = "https://api.businesscentral.dynamics.com";

        public string Environment { get; set; } = "Sandbox_Updated";

        public string Company { get; set; } = "NGB";

        public string ConfigurationName { get; set; } = "Test";

        public string CustomAuthHeader { get; set;}

        public bool Debug { get; set; } 
        public bool EnableHttpLogging { get; set; } = true;
        public bool EnableMsalLogging { get; set; } = true;
    }
}
