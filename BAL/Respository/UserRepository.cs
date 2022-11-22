using UserRegisteration2.BAL.Respository;
using UserRegisteration2.DAL;
using UserRegisteration2.Models;

namespace UserRegisteration2.BAL.Respository

{
    public class UserRepository : IUserRepository
    {

        private readonly BrightDb2Context db;

        public UserRepository(BrightDb2Context _db)
        {
            this.db = _db;
        }

        
        public void Registeration(UserViewModel userViewModel)
        {
           
            User user = new User();

            user.Id = userViewModel.Id;
            user.UserName = userViewModel.UserName;
            user.Password = userViewModel.Password;
            user.Age = userViewModel.Age;
            user.Address = userViewModel.Address;

            db.Users.Add(user);
            db.SaveChanges();
        }
       public void delete()
        {
            


            var user = db.Users.FirstOrDefault(x => x.Id == 1);

            db.Users.Remove(user);


        }
        
    }
}
