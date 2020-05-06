using System.Collections.Generic;
using Exchange.Domain.Entities;

namespace Exchange.Domain.Repositories
{
    public interface IBaseInfoDetailsRepository
    {
        List<BaseInfoDetails> GetBaseInfoDetailsByGroupId(int baseInfoGroupId);
    }
}