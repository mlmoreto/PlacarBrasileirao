using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using System.IO;
using PlacarBrasileirao.Droid;
using PlacarBrasileirao.Repository;

[assembly: Dependency(typeof(FileHelper))]
namespace PlacarBrasileirao.Droid
{
    class FileHelper : IFileHelper
    {
        public String GetLocalFilePath(String FileName)
        {
            String path = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, FileName);
        }
    }
}