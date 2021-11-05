using LogementImobilier.BO;
using LogementImobilier.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.DAL
{
    public class UserRepository: BaseRepository<User>
    {
        public User Login(string email , string password)
        {
            foreach (var data in datas)
                if (data.Id.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                    data.Password.Equals(password))
                    return data;
                    
            return null;
        }

    }
}
