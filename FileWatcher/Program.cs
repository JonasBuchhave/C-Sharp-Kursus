using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.LastWrite | System.IO.NotifyFilters.FileName;

            w.Changed += (s, e) => { Console.WriteLine("Filen " + e.Name + " er rettet"); };
            w.Renamed += (s, e) => { Console.WriteLine("Filen " + e.OldName + " er omdøbt til " + e.Name); };


            do { } while (true);
        }
    }
}
