using System.Collections.Generic;
using System.Text;
using FullContactApi.FullContactPersonItems.ContactInfoItems;
using FullContactApi.FullContactPersonItems.DemographicsItems;
using FullContactApi.FullContactPersonItems.DigitalFootprintItems;

namespace FullContactApi.FullContactPersonItems
{
    public class FullContactPerson
    {
        public int Status;
        public float Likelihood;
        public string RequestId;
        public List<Photo> Photos;
        public ContactInfo ContactInfo;
        public List<Organization> Organizations;
        public Demographics Demographics;
        public List<SocialProfile> SocialProfiles;
        public DigitalFootprint DigitalFootprint;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(string.Format("Likelihood: {0:N2}", Likelihood));
            stringBuilder.Append(ContactInfo);
            foreach (var socialProfile in SocialProfiles)
            {
                stringBuilder.AppendLine(socialProfile.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
