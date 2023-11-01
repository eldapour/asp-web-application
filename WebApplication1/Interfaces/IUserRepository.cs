using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers();
        IEnumerable<User> AllUsersBySearch(string UserName);
        User GetUserById(int Id);
        User AddUser(User user);
        User EditUser(User user);
        User DeleteUser(int Id);
    }
}
