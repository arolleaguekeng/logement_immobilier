using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    class HousingRenting:Housing
    {
        public DateTime RentingDate { get; set; }
        public DateTime EndRenting { get; set; }


    }
}
