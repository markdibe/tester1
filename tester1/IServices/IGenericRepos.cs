using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Models;

namespace tester1.IServices
{
    public interface IGenericRepos<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetById(int Id);

        Task<T> GetById(string id);

        Task<T> Create(T entity);

        Task Update(T entity);

        Task Delete(int id);
    }
}
