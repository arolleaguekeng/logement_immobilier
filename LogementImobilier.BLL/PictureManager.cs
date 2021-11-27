using LogementImobilier.BO;
using LogementImobilier.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogementImobilier.BLL
{

    public class PictureManager
    {
        public PictureReopsitoty repository;

        public PictureManager()
        {
            repository = new PictureReopsitoty();
        }

        public void AddPicture(string fileName, string targetPath)
        {
            repository.CopyPicture(fileName, targetPath);
        }

        //public void ShowListPicture(List<HousingPicture> pictures, PictureBox box, string path, HousingPicture picture, FlowLayoutPanel layoutPanel)
        //{
        //    repository.showPicturePanel(pictures,box,path,picture,layoutPanel);
        //}
    }
}
