using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.database;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers()
        {
            dbContainer db = new dbContainer();
            var data = db.users.Select(a=>a);
            return data; 
        }
        public IEnumerable<User> AllUsersBySearch(string UserName)
        {
            dbContainer db = new dbContainer();
            var data = db.users.Where(a => a.userName.Contains(UserName)).Select(a=>a);
            return data;
        }
        public User GetUserById(int Id)
        {
            dbContainer db = new dbContainer();
            var data = db.users.Find(Id);
            //var data1 = db.users.Where(a=>a.Id == Id).FirstOrDefault();
            return data;
        }
        public User AddUser(User user)
        {
            dbContainer db = new dbContainer();
            db.users.Add(user);
            db.SaveChanges();
            return user;
        }
        public User DeleteUser(int Id)
        {
            dbContainer db = new dbContainer();
            var obj = db.users.Find(Id);
            db.users.Remove(obj);
            db.SaveChanges();
            return obj;
        }
        public User EditUser(User user)
        {
            dbContainer db = new dbContainer();
            var old = db.users.Find(user.Id);
            old.userName = user.userName;
            db.SaveChanges();
            return user;
        }

       
    }
}
