
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class User:BaseModel
    {


        public string Password { get; set; }
        public byte[] profile;

        public User(string email,string fullname,string password, byte[] profile)
        {
            Id = email;
            Name = fullname;
            Password = password;
            this.profile = profile;
        }

        public User()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id.Equals(user.Id , StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
