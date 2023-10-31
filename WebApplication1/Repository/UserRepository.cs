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
        private readonly dbContainer db;
        /// <summary>
        /// repository constructor
        /// </summary>
        /// <param name="db"></param>
        public UserRepository(dbContainer db)
        {
            this.db = db;
        }
        /// <summary>
        /// return AllUsers
        /// </summary>
        /// <returns>data user</returns>
        public IEnumerable<User> AllUsers()
        {
            var data = db.users.Select(a=>a);
            return data; 
        }
        /// <summary>
        /// return AllUsersBySearch
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>data user</returns>
        public IEnumerable<User> AllUsersBySearch(string UserName)
        {
            var data = db.users.Where(a => a.userName.Contains(UserName)).Select(a=>a);
            return data;
        }
        /// <summary>
        /// return GetUserById
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>return user by id</returns>
        public User GetUserById(int Id)
        {
            var data = db.users.Find(Id);
            //var data1 = db.users.Where(a=>a.Id == Id).FirstOrDefault();
            return data;
        }
        /// <summary>
        /// return Add user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>user addition</returns>
        public User AddUser(User user)
        {
            db.users.Add(user);
            db.SaveChanges();
            return user;
        }
        /// <summary>
        /// DeleteUser
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public User DeleteUser(int Id)
        {
            var obj = db.users.Find(Id);
            db.users.Remove(obj);
            db.SaveChanges();
            return obj;
        }
        /// <summary>
        /// EditUser
        /// </summary>
        /// <param name="user"></param>
        /// <returns>user</returns>
        public User EditUser(User user)
        {
            //db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var old = db.users.Find(user.Id);
            old.userName = user.userName;
            db.SaveChanges();
            return user;
        }

       
    }
}
