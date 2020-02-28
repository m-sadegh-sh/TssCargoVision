using System;

namespace TssCargoVision.Configuration
{
    public class UnderlyingConnectionOptions
    {
        public Uri ServiceUri { get; set; }
        public TimeSpan Timeout { get; set; }
        public string UserAgentName { get; set; }
        public string UserAgentVersion { get; set; }
    }
}
