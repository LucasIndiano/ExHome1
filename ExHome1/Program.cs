using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHome1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, din;
            Console.WriteLine("Digite o valor 1: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 3: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 4: ");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 5: ");
            e = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do usuário: ");
            din = double.Parse(Console.ReadLine());
            double total = a + b + c + d + e;
            double troco = din - total;
            Console.WriteLine("Total: " + String.Format("{0:C2}", total));
            if (troco > 0) { Console.WriteLine("Troco: " + String.Format("{0:C2}", troco)); }
            else { Console.WriteLine("Não tem Troco"); }
            Console.ReadKey();
        }
    }
}
