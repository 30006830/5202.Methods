using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsCoding5202
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explains what the programs funcion is and asks for the user to enter a number.
            Console.WriteLine("This program is to take a number a display the complete opposite of it (e.g. 10 -> -10)");
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            int total = ReturnNumber(num1);

            Console.WriteLine(total);
            Console.ReadLine();
        }

        static int ReturnNumber(int number1)
        {
            return number1 - number1 * 2;
        }
        
    }
}
