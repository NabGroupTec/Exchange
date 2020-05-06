using System.Collections.Generic;
using Exchange.Domain.Entities;

namespace Exchange.Domain.Repositories
{
    public interface IVoucherLineRepository
    {
        List<VoucherLine> GetVoucherByHead(int headId);
    }
}