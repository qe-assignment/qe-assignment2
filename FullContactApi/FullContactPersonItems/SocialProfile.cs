using System;
using System.Text;

namespace FullContactApi.FullContactPersonItems
{
    public class SocialProfile
    {
        public string Bio;
        public string Type;
        public string TypeId;
        public string TypeName;
        public Uri Url;
        public string Id;
        public int Followers;
        public int Following;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Social profile:");
            stringBuilder.AppendLine("  Bio: " + Bio);
            stringBuilder.AppendLine("  Type: " + Type);
            stringBuilder.AppendLine("  TypeId: " + TypeId);
            stringBuilder.AppendLine("  TypeName: " + TypeName);
            stringBuilder.AppendLine("  Url: " + Url);
            stringBuilder.AppendLine("  Id: " + Id);
            stringBuilder.AppendLine("  Followers: " + Followers);
            stringBuilder.AppendLine("  Following: " + Following);

            return stringBuilder.ToString();
        }
    }
}
