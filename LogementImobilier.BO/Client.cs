using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class Client : BaseModel
    {
        public int PhoneNumber { get; set; }

        public Client(string email, string name,int phoneNumber)
        {
            Id = email;
            PhoneNumber = phoneNumber;
            Name = name;
        }
        
    }
}
