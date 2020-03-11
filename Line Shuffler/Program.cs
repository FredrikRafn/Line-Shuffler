using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Line_Shuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any button when 'combo.txt' is in the same folder as this program...");
            Console.ReadKey();

            var lines = File.ReadAllLines("combo.txt");
            var rnd = new Random();
            lines = lines.OrderBy(line => rnd.Next()).ToArray();
            File.WriteAllLines("shuffled_combo.txt", lines);

            Console.WriteLine("Check your folder for 'shuffled_combo.txt'!");
            Console.ReadKey();
        }
    }
}
