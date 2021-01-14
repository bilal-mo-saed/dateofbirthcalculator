using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOFBirthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int currntYear = DateTime.Now.Year;
                Console.Write("Enter your age : ");

                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Your birth year is a : " + (currntYear - age));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.Write("press any key to close... ");
                Console.ReadKey();
            }
        }
    }
}
