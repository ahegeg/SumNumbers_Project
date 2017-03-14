using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            double y = double.Parse( Console.ReadLine());

            SumBumbers_BLL.SumBumbers_BLL bll = new SumBumbers_BLL.SumBumbers_BLL();

            Console.WriteLine("Results:" + bll.SumNumbers(x, y).ToString());
        }
    }
}
