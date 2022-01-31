using DALfile.IRepository;
using MODELfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALfile.Repository
{

    public class UserService : IUser
    {
        public readonly ApplicationContext _dbcontext;

        public UserService(ApplicationContext dbcontext)
        {
            _dbcontext = dbcontext;

        }

        public Task<int> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public User Authenticate(User user)
        {
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
                return null;

            var userData = _dbcontext.Users.SingleOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);

            // check if username exists
            if (user == null)
                return null;
            return user;
        }

        public Task<int> DeleteUser(int? userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUser()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int? userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
