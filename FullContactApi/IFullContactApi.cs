using System.Threading.Tasks;

namespace FullContactApi
{
    public interface IFullContactApi
    {
        Task<FullContactPerson> LookupPersonByEmailAsync(string email);
    }
}
