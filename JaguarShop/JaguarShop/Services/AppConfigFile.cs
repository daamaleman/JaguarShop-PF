using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarShop.Services
{
    public class AppConfigFile
    {
        public bool Theme { get; set; }

        public void SaveAppConfig()
        {
            string filePath = "AppConfig.txt";

            using (FileStream myFile = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(myFile))
                {
                    writer.Write(Theme);
                }
            }
        }

        public void LoadAppConfig()
        {
            string filePath = "AppConfig.txt";
            if (!File.Exists(filePath))
            {
                Theme = false;
                return;
            }
            using (FileStream myFile = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(myFile))
                {
                    Theme = reader.ReadBoolean();
                }
            }
        }
    }
}
