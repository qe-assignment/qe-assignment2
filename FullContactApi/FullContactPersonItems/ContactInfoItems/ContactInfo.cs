using System.Collections.Generic;
using System.Text;

namespace FullContactApi.FullContactPersonItems.ContactInfoItems
{
    public class ContactInfo
    {
        public string FriendlyName;
        public string FullName;
        public string GivenName;
        public List<WebSite> WebSites;
        public List<Chat> Chats;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ContactInfo:");
            stringBuilder.AppendLine(string.Format("    Friendly name: {0}", FriendlyName));
            stringBuilder.AppendLine(string.Format("    Full name: {0}", FullName));
            stringBuilder.AppendLine(string.Format("    Given name: {0}", GivenName));
            stringBuilder.AppendLine("  Websites:");
            foreach (var webSite in WebSites)
            {
                stringBuilder.AppendLine("  " + webSite);
            }
            foreach (var chat in Chats)
            {
                stringBuilder.AppendLine("  " + chat);
            }

            return stringBuilder.ToString();
        }
    }
}
