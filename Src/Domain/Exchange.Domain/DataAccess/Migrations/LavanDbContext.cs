using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Domain.DataAccess.Migrations
{
    public class LavanDbContext:DbContext
    {
        static LavanDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LavanDbContext>());
        }

    }
}
