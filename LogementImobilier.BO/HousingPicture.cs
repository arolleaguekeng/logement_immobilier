using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BO
{
    public class HousingPicture
    {
        public byte[] Location { get; set; }
        public string Title { get; set; }

        public HousingPicture(byte[] location, string title)
        {
            Location = location;
            Title = title;
        }

        public HousingPicture()
        {
        }
    }
}
