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
            
            //takes an integer (string) from the user and converts it to a true integer for use.
            int num1 = int.Parse(Console.ReadLine());
            //the total is stored in the variable total.
            int total = ReturnNumber(num1);

            //Console.WriteLine function is being used to output the total variable.
            Console.WriteLine(total);
            Console.ReadLine();
        }

        //new method for a return statement, The use is an int.
        //ReturnNumber is the name of the method so that it can be ued in the above block of code.
        static int ReturnNumber(int number1)
        {
            return number1 - number1 * 2; //the int number1 is subtracted by itself twice, hence why there is the * 2.
        }
        
    }
}
