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
        public decimal CalculPrice(decimal Surface, decimal meterPrice, int ItemTax, int levelOfHousing, int LocationTaxe)
        {
            return ((Surface * meterPrice) + (meterPrice + levelOfHousing + ItemTax + LocationTaxe));
        }

    }
}
