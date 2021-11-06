using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BLL
{
    public class HousingRentingManager: HousingManager
    {
        public HousingRentingManager()
        {

        }

        public decimal CalculPrice(int numberRoom, int numberKitchens,int levelOfHousing,int numberExhibition,int numberShower,int duration)
        {
            return ((numberRoom*2000)+(numberShower*3000)+(numberKitchens*3000)+(levelOfHousing * 5000)+(numberExhibition*15000))*duration;
            
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
    }
}
