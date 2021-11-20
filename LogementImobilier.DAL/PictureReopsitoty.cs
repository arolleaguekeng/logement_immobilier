using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.DAL
{
    public class PictureReopsitoty
    {
        public void CopyPicture(string fileName, string targetPath)
        {

            // Use Path class to manipulate file and directory paths.
            // To copy a file to another location and
            // overwrite the destination file if it already exists.

            FileInfo fileInfo = new FileInfo(targetPath);
            if (!fileInfo.Directory.Exists)
                fileInfo.Directory.Create();
            System.IO.File.Copy(fileName, targetPath, true);
        }
    }
}
