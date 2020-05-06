using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;
using Exchange.Domain.Repositories;

namespace Exchange.Domain.Services
{
    public class VoucherLineRepository : IVoucherLineRepository, IDisposable
    {
        private readonly ExchangeDbContext _db = new ExchangeDbContext();


        public void Dispose()
        {
            _db.Dispose();
        }


        public List<VoucherLine> GetVoucherByHead(int headId)
        {
            var result = _db.VoucherLines.Include(info => info.VoucherHeader).Where(p => p.VoucherHeaderId == headId)
                .ToList();
            return result;
        }
    }
}