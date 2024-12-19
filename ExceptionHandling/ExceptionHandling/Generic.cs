using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    //internal class Generic: Exception
    //{

    //    public static void StackPractise()
    //    {
    //        Stack<string> stk = new Stack<string>();
    //        //stk.Push("cs.net");
    //        //stk.Push("vb.net");
    //        //stk.Push("asp.net");
    //        //stk.Push("ado.net");
    //        stk.Push(1);
    //        foreach (string s in stk)
    //        {
    //            Console.WriteLine(s);
    //        }
    //    }





    //    //********Queue*******
    //    public static void QueuePractise()
    //    {
    //        Queue<string> que = new Queue<string>();
    //        que.Enqueue("cs.net");
    //        que.Enqueue("vb.net");
    //        que.Enqueue("asp.net");
    //        que.Enqueue("ado.net");

    //        foreach (var element in que)
    //        {
    //            Console.WriteLine(element);
    //        }
    //    }

    // }
    //  ======================================================================>
    class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.Write("Exception occurred : ");
        }

        public double DivOperation(double num, double deno)
        {
            if (deno == 0)
               // throw new DivByZero();
                throw new NotImplementedException();
            return num/ deno;
        }
    }                       
}
