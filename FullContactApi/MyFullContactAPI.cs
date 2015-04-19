using System.Threading.Tasks;

namespace FullContactApi
{
    public class MyFullContactApi : IFullContactApi
    {
        public Task<FullContactPerson> LookupPersonByEmailAsync(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
