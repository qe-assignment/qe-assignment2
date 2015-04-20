using System.Collections.Generic;
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
    }
}
