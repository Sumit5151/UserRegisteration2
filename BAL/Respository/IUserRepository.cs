using UserRegisteration2.Models;

namespace UserRegisteration2.BAL.Respository
{
    public interface IUserRepository
    {
        void Registeration(UserViewModel userViewModel);
        void delete();
    }
}
