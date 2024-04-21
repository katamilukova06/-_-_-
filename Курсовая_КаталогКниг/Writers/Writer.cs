using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_КаталогКниг.Writers
{
    internal class Writer
    {
        public static void WriteToFiles(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var item in Greeting.ListOfBooks)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
    }
}
