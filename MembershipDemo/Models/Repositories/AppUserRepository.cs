using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MembershipDemo.Models.Entities;
using MembershipDemo.Models.Repositories.Abstract;

namespace MembershipDemo.Models.Repositories
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        void DeleteUserByUserName(string Username);
    }

    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        public AppUserRepository() : base() { }

        public void DeleteUserByUserName(string Username)
        {
            var user = FindAll(u => u.Username == Username).FirstOrDefault();
            Delete(user);
        }
    }
}