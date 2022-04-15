using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DA_PhanHe1.Helper;

namespace DA_PhanHe1.User
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dataContext)
            : base(dataContext)
        {
        }
    }
}
