using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{ //===============================Example (1)
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Generic.StackPractise();
    //            Console.WriteLine("Stack added");

    //        }
    //        catch (Exception ex)
    //        {
    //            //throw ex;
    //            Console.WriteLine($"Error { ex.Message}");
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Code ends...");
    //        }
    //    }
    //}

    //================================>Example(2)
    //class Array
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3, 8, 6, 12, 22 };

    //        //for (int i = 0; i < arr.Length; i++)
    //        //{
    //        //    Console.WriteLine(arr[i]);
    //        //}

    //        try
    //        {
    //            Console.WriteLine(arr[8]);
    //        }
    //        catch (Exception ex) 
    //        {
    //             Console.WriteLine(ex);
    //            Console.WriteLine("An Exception has occurred : {0}", ex.Message);
    //        }
    //    }
    //}

    //============================================>Example(3)

    class Program
    {
        static void Main(string[] args)
        {
            
                DivByZero obj = new DivByZero();
            double num = 9, deno = 0, quotient;
            try
            {
                // Code block that may cause an exception
                Console.WriteLine("Quotient = {0}", (float)obj.DivOperation(num, deno));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //private double DivOperation(double num, double den)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

    
        
    
