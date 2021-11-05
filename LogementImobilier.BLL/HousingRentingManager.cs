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
    }
}
