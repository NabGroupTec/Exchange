using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.Domain.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private readonly ExchangeDbContext _db;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ExchangeDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null) query = query.Where(@where);

            return query.ToList();
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void UpdateLine(ICollection<VoucherLine> entity)
        {
            foreach (var item in entity) _db.Entry(item).State = EntityState.Modified;

            _db.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached) _dbSet.Attach(entity);

            _dbSet.Remove(entity);
        }

        public virtual void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
        }
    }
}