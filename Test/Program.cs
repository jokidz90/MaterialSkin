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
            string imgDirectory = @"D:\Icon";
            var allFiles = Directory.GetFiles(imgDirectory, "*", SearchOption.TopDirectoryOnly);
            foreach (var file in allFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                Console.WriteLine(fileName);
                Debug.WriteLine(Path.GetFileNameWithoutExtension(fileName)+",");
            }
        }
    }
}
