using System.Threading.Tasks;
using FullContactApi.FullContactPersonItems;

namespace FullContactApi
{
    public interface IFullContactApi
    {
        Task<FullContactPerson> LookupPersonByEmailAsync(string email);
    }
}
