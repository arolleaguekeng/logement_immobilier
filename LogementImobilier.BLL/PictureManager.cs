using LogementImobilier.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BLL
{

    public class PictureManager
    {
        public PictureReopsitoty picture;

        public PictureManager()
        {
            picture = new PictureReopsitoty();
        }

        public void AddPicture(string fileName, string targetPath)
        {
            picture.CopyPicture(fileName, targetPath);
        }
    }
}
