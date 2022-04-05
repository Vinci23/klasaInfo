using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace klasaInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\bla");

            DirectoryInfo di = new DirectoryInfo(@"c:\");
            Console.WriteLine("\n Poddirektoriji: ");

            foreach(DirectoryInfo diInfo in di.GetDirectories())
            {
                Console.WriteLine("{0}\t{1}\t{2}", diInfo.Name, diInfo.CreationTime, diInfo.LastAccessTime);
            }

            foreach (FileInfo fiInfo in di.GetFiles())
            {
                Console.WriteLine("{0}\t\t\t{1}\t{2}", fiInfo.Name, fiInfo.CreationTime, fiInfo.LastAccessTime);
            }


            Console.ReadKey();
        }
    }
}
