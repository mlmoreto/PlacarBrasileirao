using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using PlacarBrasileirao.iOS;
using System.IO;
using PlacarBrasileirao.Repository;

[assembly: Dependency(typeof(FileHelper))]
namespace PlacarBrasileirao.iOS
{
    class FileHelper : IFileHelper
    {
        public String GetLocalFilePath(String FileName)
        {
            //local onde ele esta
            String docFolfer = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //gravou em library subdiretorio Databases
            String libFolder = Path.Combine(docFolfer, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, FileName);
        }
    }
}