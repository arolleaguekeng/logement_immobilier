using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BLL
{
    public class HousingSaleManager:HousingManager
    {
        public HousingSaleManager()
        {

        }
        public decimal CalculPrice(decimal Surface, decimal meterPrice, int levelItem, int levelOfHousing, int levelLocation)
        {
            return ((Surface * meterPrice) + (meterPrice + levelOfHousing + levelItem + levelLocation));
        }
    }
}
