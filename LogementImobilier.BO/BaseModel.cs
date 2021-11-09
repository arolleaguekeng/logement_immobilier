using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public int NumberRoom { get; set; }
        public int NumberKitchen { get; set; }
        public int NumberShower { get; set; }
        public int NumberExibition { get; set; }
        public float NumberStart { get; set; }
        public Client HousingClient { get; set; }
        public bool Terrasse { get; set; }
        public bool Parking { get; set; }

        public bool Used { get; set; }

        public BaseModel(string id, string name)
        {
            Id = id;
            Name = name;
        }
        public BaseModel()
        {

        }
    }
}
