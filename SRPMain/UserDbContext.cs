using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPMain
{
    internal interface DbMock
    {
        void Save(User user);
    }

    internal class UserDbContext : DbMock
    {
        public void Save(User user)
        {
            //Database save
        }
    }
}
