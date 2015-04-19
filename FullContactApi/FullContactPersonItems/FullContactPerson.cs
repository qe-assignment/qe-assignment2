using System.Collections.Generic;
using FullContactApi.FullContactPersonItems.ContactInfoItems;
using FullContactApi.FullContactPersonItems.Demographics;
using FullContactApi.FullContactPersonItems.PhotoItems;

namespace FullContactApi.FullContactPersonItems
{
    public class FullContactPerson
    {
        public int Status;
        public string RequestId;
        public float Likelihood;
        public List<Photo> Photos;
        public ContactInfo ContactInfo;
        public List<Organization> Organizations;
        public Demographic Demographic;
        public List<SocialProfile> SocialProfiles;
        public DigitalFootprint DigitalFootprint;
    }
}
