using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class Housing : BaseModel
    {

        public decimal Price { get; set; }
        public string Location { get; set; }
        public int NumberRoom { get; set; }
        public int NumberKitchen { get; set; }
        public int NumberShower { get; set; }
        public int NumbreExibition { get; set; }

        public bool Used { get; set; }


        public Housing()
        {

        }
        
    }
}
