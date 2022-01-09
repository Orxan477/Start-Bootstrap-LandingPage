using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Start_Bootstrap_Landing_page_.Utilities
{
    public static class Helper
    {
        public  static void RemoveFile(string root,string folder,string file)
        {
            var photo = Path.Combine(root, folder, file);
            if (File.Exists(photo))
            {
                File.Delete(photo);
            }
        }
    }
}
