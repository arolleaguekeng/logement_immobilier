using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class Housing : BaseModel
    {
        public string Password { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public int NumbreHalls { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public List<Item> Items { get; set; }
        public bool Used { get; set; }


        public Housing()
        {

        }
        
    }
}
