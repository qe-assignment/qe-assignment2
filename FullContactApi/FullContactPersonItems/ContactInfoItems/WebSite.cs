using System;
using System.Text;

namespace FullContactApi.FullContactPersonItems.ContactInfoItems
{
    public class WebSite
    {
        public Uri Url;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Website: ");
            stringBuilder.AppendLine("  " + Url);
            return stringBuilder.ToString();
        }
    }
}
