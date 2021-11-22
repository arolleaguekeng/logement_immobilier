using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class Historic : BaseModel
    {
        public DateTime dateTime { get; set; }
        public string operation { get; set; }

        public Housing HousingHis { get; set; }
    }
}
