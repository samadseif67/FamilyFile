using FamilyFile.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Domain.Interfaces
{
    public interface IRepository<T>
        where T : class

    {
        T Add(T entity);
        T Update(T entity);
        bool Delete(Guid id);
        T? Find(Guid Id);
        List<T> GetAll();
        Task<T> AddAsync(T entity);
        Task<T?> FindAsync(Guid Id);
        Task<List<T>> GetAllAsync();
        void SaveChanges();
        void SaveChangesAsync();
         
    }
}
