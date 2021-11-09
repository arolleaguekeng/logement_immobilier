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
        public int NumberExibition { get; set; }
        public float NumberStart { get; set; }
        public Client HousingClient { get; set; }
        public bool Terrasse { get; set; }
        public bool Parking { get; set; }
        public bool Used { get; set; }
        public int NumberOfLevel { get; set; }


        public Housing(string id,string name,decimal price, string location, int numberRoom, int numberKitchen, int numberShower,
                        int numberExibition, float numberStart, bool used,Client client,bool terasse,bool parking,int numberOfLevel)
        {
            Id = id;
            Name = name;
            Price = price;
            Location = location;
            NumberRoom = numberRoom;
            NumberKitchen = numberKitchen;
            NumberShower = numberShower;
            NumberExibition = numberExibition;
            NumberStart = numberStart;
            Used = used;
            HousingClient = client;
            Terrasse = terasse;
            Parking = parking;
            NumberOfLevel = numberOfLevel;
        }
    }
}
