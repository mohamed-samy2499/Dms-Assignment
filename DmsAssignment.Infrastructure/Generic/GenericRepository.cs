﻿using Microsoft.EntityFrameworkCore;
using DmsAssignment.Domain.Entities;
using DmsAssignment.Infrastructure.Database;
using System.Linq.Expressions;

namespace DmsAssignment.Infrastructure.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public virtual async Task<string> CreateAsync(T entity)
        {
            await _appDbContext.Set<T>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return "success";
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            entity.DateUpdated = DateTime.Now;
            _appDbContext.Entry(entity).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<string> DeleteAsync(int id)
        {
            var entity = await _appDbContext.Set<T>().FindAsync(id);

            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DateDeleted = DateTime.Now;
                //_appDbContext.Entry(entity).State = EntityState.Deleted;
                await _appDbContext.SaveChangesAsync();
                return "success";
            }
            return "Fails";
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>>[] includes = null)
        {
            IQueryable<T> query = _appDbContext.Set<T>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();

        }

        public virtual async Task<T> GetByIdAsync(int id, Expression<Func<T, object>>[] includes = null)
        {
            IQueryable<T> query = _appDbContext.Set<T>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            var entity = await query.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

    }
}
