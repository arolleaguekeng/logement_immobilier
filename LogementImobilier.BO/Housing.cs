using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class Housing : BaseModel
    {
        private Housing housing;

        public byte[] ProfileIcon { get; set; }
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
        public List<HousingPicture> HousingPitctures { get; set; }

        public Housing(string id,string name,decimal price, string location, int numberRoom, int numberKitchen, int numberShower,
                        int numberExibition, float numberStart, bool used,Client client,bool terasse,bool parking,int numberOfLevel,List<HousingPicture> picture,byte[] profile)
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
            HousingPitctures = picture;
            ProfileIcon = profile;
        }

        public Housing()
        {
        }

        public Housing(Housing housing)
        {
            this.housing = housing;
        }

        public static implicit operator List<object>(Housing v)
        {
            throw new NotImplementedException();
        }
    }
}
