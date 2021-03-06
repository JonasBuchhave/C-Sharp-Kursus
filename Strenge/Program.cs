﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Mikkel";
            Console.WriteLine(fornavn);

            string efternavn = "Cronberg";
            Console.WriteLine(efternavn);

            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            string[] arr = samletNavn.Split(' ');
            for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);


            Console.WriteLine(fornavn + "\t\t***\t\t" + efternavn);
            Console.WriteLine(fornavn + "\r\n***\r\n" + efternavn);
            System.IO.File.WriteAllText(@"c:\temp\mc.txt", samletNavn);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
