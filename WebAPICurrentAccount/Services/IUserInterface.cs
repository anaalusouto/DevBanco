using WebAPICurrentAccount.Dto;
using WebAPICurrentAccount.Models;

namespace WebAPICurrentAccount.Services
{
    public interface IUserInterface
    {

        Task<ResponseModel<List<UserListarDto>>> SearchUser();
    }
}
