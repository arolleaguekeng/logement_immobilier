using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class Saling
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Saling(DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public Saling()
        {
        }
    }
}
