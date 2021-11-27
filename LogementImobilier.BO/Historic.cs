using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class Historic : BaseModel
    {
        public DateTime DateTime { get; set; }
        public string Operation { get; set; }

        public Housing HousingHis { get; set; }

        public Historic(DateTime dateTime, string operation, Housing housingHis)
        {
            this.DateTime = DateTime.Now;
            this.Operation = operation;
            HousingHis = housingHis;
        }
        public Historic()
        {

        }
    }
}
