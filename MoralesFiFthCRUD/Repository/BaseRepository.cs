﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoralesFiFthCRUD.Contracts;
using System.Data.Entity;

namespace MoralesFiFthCRUD.Repository
{
    public class ProductRepository : BaseRepository<Products>
    {

    }
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private DbContext _db;
        public DbSet<T> _table;
        public BaseRepository()
        {
            _db = new database3Entities();
            _table = _db.Set<T>();
        }
        public T Get(object id)
        {
            return _table.Find(id);
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }
        public ErrorCode Create(T t)
        {
            try
            {
                _table.Add(t);
                _db.SaveChanges();
                return ErrorCode.Success;
            }
            catch (Exception )
            {
                return ErrorCode.Error;
            }

        }

        public ErrorCode Delete(object id)
        {
            try
            {
                var obj = Get(id);
                _table.Remove(obj);
                _db.SaveChanges();
                return ErrorCode.Success;
            }
            catch (Exception )
            {
                return ErrorCode.Error;
            }
        }

     
        public ErrorCode Update(object id, T t)
        {
            try
            {
                var oldOjb = Get(id);
                _db.Entry(oldOjb).CurrentValues.SetValues(t);
                _db.SaveChanges();
                return ErrorCode.Success;
            }
            catch (Exception )
            {
                return ErrorCode.Error;
            }
        }

        public ErrorCode DeleteProduct(object ProductID)
        {
            try
            {
                var obj = Get(ProductID);
                _table.Remove(obj);
                _db.SaveChanges();
                return ErrorCode.Success;
            }
            catch (Exception )
            {
                return ErrorCode.Error;
            }
        }

        Contracts.ErrorCode IBaseRepository<T>.Create(T t)
        {
            throw new NotImplementedException();
        }

        Contracts.ErrorCode IBaseRepository<T>.Update(object id, T t)
        {
            throw new NotImplementedException();
        }

        Contracts.ErrorCode IBaseRepository<T>.Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}