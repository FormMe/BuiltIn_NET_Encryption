using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiltIn_NET_Encryption
{
    class FileManager
    {
        public string encrypFile;
        public string decrypFile;
        public string decrypedFile;
        
        public static string SetFile()
        {
            using (var fd = new OpenFileDialog())
            {
                return fd.ShowDialog() != DialogResult.OK 
                    ? null 
                    : fd.FileName;
            }
        }

    }
}
