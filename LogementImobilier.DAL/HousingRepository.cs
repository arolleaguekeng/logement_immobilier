using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.DAL
{
    public class HousingRepository : BaseRepository<Housing>
    {
        public List<Housing> Find
            (
            string location, int numberExibition, int numberKitchen, int numberRoom, int numberShower,
                                     bool parking, bool terasse, decimal price, float numberStars
            )
        {
            var result = from h in datas
                         where h.Location.Contains(location)&& (
         h.Price == price || h.NumberExibition == numberExibition ||
         h.NumberKitchen == numberKitchen || h.NumberRoom == numberRoom ||
         h.NumberShower == numberShower || h.NumberStart == numberStars ||
         h.Parking == parking || h.Terrasse == terasse)
                         select h;
            return result.ToList();

        }




        public List<Housing> FindByPriceasc()

        {
            var result = from h in datas
                         orderby h.Price ascending
                         select h;
            return result.ToList();

        }
        public List<Housing> FindByPricedesc()

        {
            var result = from h in datas
                         orderby h.Price descending
                         select h;
            return result.ToList();

        }




        public List<Housing> FindByName(string name)
        {
            var result = from h in datas
                         where  h.Location.Contains(name)
                         select h;
            return result.ToList();

        }

        public List<Housing> FindBystartsasc()
        {
            var result = from h in datas
                         orderby h.NumberStart ascending
                         select h;
            return result.ToList();
        }
        public List<Housing> FindBystartdesc()
        {
            var result = from h in datas
                         orderby h.NumberStart descending
                         select h;
            return result.ToList();
        }
        public string[] GetAllBasicsPrices()
        {
            return File.ReadAllText(@"Data\config\conft_price.bb").Split('\n');
        }
    }
}
