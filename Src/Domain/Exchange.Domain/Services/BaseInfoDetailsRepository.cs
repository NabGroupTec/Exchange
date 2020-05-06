using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;
using Exchange.Domain.Repositories;

namespace Exchange.Domain.Services
{
    public class BaseInfoDetailsRepository : IBaseInfoDetailsRepository, IDisposable
    {
        private readonly ExchangeDbContext _db = new ExchangeDbContext();


        public List<BaseInfoDetails> GetBaseInfoDetailsByGroupId(int baseInfoGroupId)
        {
            var result = _db.BaseInfoDetails.Include(info => info.BaseInfoGroup)
                .Where(p => p.BaseInfoGroupId == baseInfoGroupId)
                .ToList();
            return result;
        }


        public void Dispose()
        {
            _db.Dispose();
        }
    }
}