using LogementImobilier.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.DAL
{
    public class HousingRepository : BaseRepository<Housing>
    {
        public List<Housing> FindByName(string name, string location, int numberExibition, int numberKitchen, int numberRoom, int numberShower, bool parking, bool terasse, decimal price, float numberStars)
        {
            var result = from h in datas
                         where (h.Location.Contains(location) ||
         h.Price <= price || h.NumberExibition == numberExibition ||
         h.NumberKitchen == numberKitchen || h.NumberRoom == numberRoom ||
         h.NumberShower == numberShower || h.NumberStart == numberStars ||
         h.Parking == parking || h.Terrasse == terasse)&& h.Name.Contains(name) 
                         select h;
            return result.ToList();

        }
    }
}
