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
        public Dictionary<int,string> levelItems;
        public Dictionary<int,string> levelHousing;
        public Dictionary<int, string> levelLocation;

        public HousingManager()
        {
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
        public void GetAllHousing()
        {
            housinRepository.GetAll();
        }
        public decimal CalculSurface(decimal longs, decimal larg)
        {
            return (longs * larg );
        }



    }
}
