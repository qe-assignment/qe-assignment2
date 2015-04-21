using System.Text;

namespace FullContactApi.FullContactPersonItems.ContactInfoItems
{
    public class Chat
    {
        public string Client;
        public string Handle;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Chat:");
            stringBuilder.AppendLine("  " + Client);
            stringBuilder.AppendLine("  " + Handle);

            return stringBuilder.ToString();
        }
    }
}
