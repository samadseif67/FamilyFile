using FamilyFile.Domain.Entities;
using FamilyFile.Domain.Interfaces;
using FamilyFile.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Infrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class, IBaseEntitie
    {
        protected readonly FamilyFileContext _db;
        public Repository(FamilyFileContext db)
        {
            _db = db;
        }
        public T Add(T entity)
        {
            entity.Id = (entity.Id==Guid.Empty)? Guid.NewGuid(): entity.Id; 
            _db.Set<T>().Add(entity);
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            entity.Id = (entity.Id == Guid.Empty) ? Guid.NewGuid() : entity.Id;
            await _db.Set<T>().AddAsync(entity);
            return entity;
        }

        public bool Delete(Guid id)
        {
            var find = Find(id);
            _db.Set<T>().Remove(find);
            return true;
        }

        public T? Find(Guid id)
        {
            return _db.Set<T>().Find(id);
        }

        public async Task<T?> FindAsync(Guid id)
        {
            var result = await _db.Set<T>().FindAsync(id);
            return result;
        }

        public List<T> GetAll()
        {
            var result = _db.Set<T>().ToList();
            return result;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var result = await _db.Set<T>().ToListAsync();
            return result;
        }

        public T Update(T entity)
        {
            _db.Set<T>().Update(entity).Property("Code").IsModified=false;            
            return entity;
        }

        public void SaveChanges()
        {
           _db.SaveChanges();           
        }

        public void SaveChangesAsync()
        {           
            _db.SaveChangesAsync();
        }

    }
}
