using System;

namespace FullContactApi.FullContactPersonItems.ContactInfoItems
{
    public class WebSite
    {
        public Uri Url;

        public override string ToString()
        {
            return "        " + Url;
        }
    }
}
