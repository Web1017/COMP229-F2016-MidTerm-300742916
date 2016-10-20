using Microsoft.Owin;

namespace COMP229_F2016_MidTerm_300742916
{
    internal class CookieAuthenticationOptions
    {
        public object AuthenticationType { get; set; }
        public PathString LoginPath { get; set; }
    }
}