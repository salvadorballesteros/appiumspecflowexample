using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowSample
{
    public class Settings
    {
        public Uri RemoteServerAddress { get; set; }
        public string PlatformName { get; set; }
        public string PlatformVersion { get; set; }
        public string DeviceName { get; set; }
        public string App { get; set; }
        public string AutomationVersion { get; set; }
    }
}
