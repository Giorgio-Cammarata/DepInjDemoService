using DIdemoLibrary.Models;

namespace DIdemoLibrary
{
    public interface IApiService
    {
        Customer GetCustomer(int id);
    }
}
