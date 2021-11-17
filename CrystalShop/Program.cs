using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountGold;
            int amountCrystal;
            int costCrystal = 7;
            
            Console.WriteLine("Сколько у Вас есть золота?");
            amountGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Один кристалл стоит {costCrystal} золота.");
            Console.WriteLine("Какое кол-во кристалов желаете приобрести?");
            amountCrystal = Convert.ToInt32(Console.ReadLine());

            amountGold -= amountCrystal * costCrystal;

            Console.WriteLine("У вас - " + amountCrystal + " кристалов и " + amountGold + " золота.");
            Console.ReadLine();
        }
    }
}
