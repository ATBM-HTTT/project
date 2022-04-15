using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DA_PhanHe1.Helper
{
    public class AppDbContext : DbContext
    {
        //NOTE: Public access modifier in constructor
        public AppDbContext()
            : base("name=DbContext")
        {
        }
    }
}
