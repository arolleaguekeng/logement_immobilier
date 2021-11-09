using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class Housing : BaseModel
    {
        public Housing(string id,string name,decimal price, string location, int numberRoom, int numberKitchen, int numberShower,
                        int numberExibition, float numberStart, bool used,Client client,bool terasse,bool parking)
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
        }
    }
}
