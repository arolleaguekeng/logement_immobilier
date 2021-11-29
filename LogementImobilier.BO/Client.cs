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
        public Housing Housing { get; set; }
        public DateTime StarDate { get; set; }
        public int time { get; set; }
        public DateTime SndDate { get; set; }

        public Client(Housing housing,DateTime starDate,string id , string name ,int phoneNumber)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            StarDate = starDate;
            housing = Housing;


            
        }
        public Client()
        {
            
        }
    }
}
