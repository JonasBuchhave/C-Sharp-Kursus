using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            //Delegate funktion fra framework
            m.Log = Console.WriteLine;

            //Egen delegate funktion
            m.Log += AppendLog;

            //Anonym delegate funktion
            m.Log += delegate (string txt) { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "(anonym) \r\n"); };

            //Lambda anonym delegate funktion
            m.Log += txt => { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "(lambda) \r\n"); };

            m.Start();
            m.Stop();

            Console.ReadKey();
        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "(Appendlog) \r\n");
        }

    }

    //public delegate void LogDelegate(string txt);

    class Maskine
    {
        //public LogDelegate Log { get; set; }
        public Action<string> Log { get; set; }

        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + " Starter");
        }

        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }
}
