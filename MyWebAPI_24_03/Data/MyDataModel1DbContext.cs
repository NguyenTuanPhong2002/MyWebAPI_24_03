using Microsoft.EntityFrameworkCore;
using MyWebAPI_24_03.Model1;
using System.Collections.Generic;

namespace MyWebAPI_24_03.Data
{
    public class MyDataModel1DbContext : DbContext
    {
        internal object APIConnectDb;

        public MyDataModel1DbContext(DbContextOptions<MyDataModel1DbContext> opt) : base(opt)
        {

        }
    }

}
