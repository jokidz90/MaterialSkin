using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string imgDirectory = @"D:\Icon";
            //var allFiles = Directory.GetFiles(imgDirectory, "*", SearchOption.TopDirectoryOnly).ToList();
            //foreach (var file in allFiles)
            //{
            //    string fileName = Path.GetFileNameWithoutExtension(file);
            //    //if (!fileName.ToUpper().EndsWith("BLACK_48DP.PNG"))
            //    //    continue;
            //    //Console.WriteLine(fileName);

            //    //File.Copy(file, file.Replace("BLACK_48DP.PNG", ""));
            //    //File.Delete(file);

            //    Debug.WriteLine(Path.GetFileNameWithoutExtension(fileName) + ",");
            //}
            string sourceDirectory = @"C:\Users\Mandala\Downloads\material-design-icons-master";
            string destDirectory = @"D:\Icon\";
            var allSubDir = Directory.GetDirectories(sourceDirectory);
            foreach (var subDir in allSubDir)
            {
                if (!subDir.ToLower().EndsWith("toggle"))
                    continue;
                var iconPath = subDir + @"\1x_web";
                if (!Directory.Exists(iconPath))
                    continue;
                var allIcons = Directory.GetFiles(iconPath);
                foreach (var icon in allIcons)
                {
                    if (!icon.ToLower().EndsWith("_black_24dp.png"))
                        continue;

                    string iconName = icon.Replace(iconPath, "").Replace("ic_", "").Replace("_black_24dp.png", "").Replace("\\", "").ToUpper();
                    string subDirName = subDir.Replace(sourceDirectory, "").Replace("\\", "").ToUpper();
                    iconName = subDirName + "_" + iconName;
                    Debug.WriteLine(iconName);
                    Console.WriteLine(iconName);
                    iconName = iconName + ".png";
                    File.Copy(icon, destDirectory + iconName);
                }
            }
        }
    }
}
