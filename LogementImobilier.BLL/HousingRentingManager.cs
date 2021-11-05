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

        public decimal CalculPrice(decimal Surface,decimal meterPrice, int levelItem,int levelOfHousing,int levelLocation,decimal time)
        {
            return ((Surface * meterPrice) + (meterPrice + levelOfHousing + levelItem + levelLocation))*time;
            
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
