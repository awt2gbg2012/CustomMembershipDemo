using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipDemo.Models.Entities.Abstract;

namespace MembershipDemo.Models.Repositories.Abstract
{
    public interface IRepository<T> where T : class, IEntity
    {
        DbContext Model { get; }

        IQueryable<T> FindAll(Func<T, bool> filter = null);
        T FindByID(int id);
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);

        void Commit();
    }
}
