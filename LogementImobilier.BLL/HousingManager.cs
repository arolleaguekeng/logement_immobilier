using LogementImobilier.BO;
using LogementImobilier.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BLL
{
    public class HousingManager
    {
        public HousingRepository housinRepository;
        public List<int> basePrise;

        public HousingManager()
        {
            basePrise = new List<int>();
            housinRepository = new HousingRepository();
        }
        public void CreateHousing(Housing housing)
        {
            housinRepository.Add(housing);
        }
        public void EditHousing(Housing oldHousing , Housing newHousing)
        {
            housinRepository.Set(oldHousing, newHousing);
        }
        public void DeleteHousing(Housing housing)
        {
            housinRepository.Delete(housing);
        }
        public List<Housing> GetAllHousing()
        {
            return housinRepository.GetAll();
        }
        public decimal CalculSurface(decimal longs, decimal larg)
        {
            return (longs * larg );
        }

        public List<Housing> Search( string location, int numberExibition, int numberKitchen, int numberRoom, int numberShower, bool parking, bool terasse, decimal price, float numberStars)
        {
            return housinRepository.Find(location,numberExibition,numberKitchen,numberRoom,
                                                numberShower,parking,terasse,price,numberStars);
        }




        public List<Housing> SearchName(string name)
        {
            return housinRepository.FindByName(name);
        }

        //File.WriteAllText(path, nudExibition.Value.ToString() + "\n" + nudKitchen.Value.ToString() + "\n" + nudLevel.Value.ToString() + "\n" +
        //            nudNotation.Value.ToString() + "\n" + nudParking.Value.ToString() + "\n" + nudRooms.Value.ToString() + "\n" + nudShowers.Value.ToString());
        
        public decimal CalculPrice(int numberRoom, int numberKitchens, int levelOfHousing, int numberExhibition, int numberShower, int duration,int level)
        {
            foreach (var price in housinRepository.GetAllBasicsPrices())
            {
                basePrise.Add(int.Parse(price));
            }
            return (basePrise[4]+basePrise[7] +(numberRoom * basePrise[5]) + (numberShower * basePrise[6]) + (numberKitchens * basePrise[1]) + 
                    (levelOfHousing * basePrise[3]) + ((numberExhibition * basePrise[0])) * duration+(level*basePrise[2]));
        }

        public void Rending(Housing housing, Housing rentingHousing)
        {
            if (housing.Used == false)
                housing.Used = true;
            housinRepository.Set(housing, rentingHousing);
        }

        public void EndRending(Housing housing, Housing newHousing, DateTime endRendingDate)
        {
            if (housing.Used == true)
            {
                housing.Used = false;
                housinRepository.Set(housing, newHousing);
            }
        }

        public List<Housing> FilterByPriceasc()
        {
            return housinRepository.FindByPriceasc();
        }
        public List<Housing> FilterByPricedesc()
        {
            return housinRepository.FindByPricedesc();
        }

        public List<Housing> FilterByStarsasc()
        {
            return housinRepository.FindBystartsasc();
        }
        public List<Housing> FilterByStarsdesc()
        {
            return housinRepository.FindBystartdesc();
        }
        public void SaleHousing(Housing oldHousing, Housing newHousing,Client client,Saling saling)
        {
            newHousing.Used = true;
            newHousing.HousingClient = client;
            newHousing.HousingSaling = saling;
            housinRepository.Set(oldHousing, newHousing);
        }

        public void LeaveHousing(Housing saleHousing, Housing newHousing, Client client)
        {
            newHousing.Used = true;
            newHousing.HousingClient = client;
            housinRepository.Set(saleHousing, newHousing);

        }
    }
}
