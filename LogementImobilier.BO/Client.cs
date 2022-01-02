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
        public List<Housing> housing { get; set; }
        public Client(string id , string name ,int phoneNumber)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            this.housing = housing;



            
        }
        public Client()
        {
            
        }
    }
}
