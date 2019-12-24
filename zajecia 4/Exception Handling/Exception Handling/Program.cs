using System;
using System.IO;
using System.Net.Http;
using Version = System.Version;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //var calculator = new Calculator();
            //var result = calculator.Divide(5, 0);


            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(0, 4);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Don't divide by 0!!'");
            }
            catch (ZeroNumerator e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Do it anyway");
            }




            Console.ReadKey();
        }
    }
}
