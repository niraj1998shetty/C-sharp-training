using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCode1
{
    internal class ExceptionHandle
    {
        //Exception handling try catch 
            try
            {
                int[] myNumbers = { 1, 2, 3 };
        Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
    Console.WriteLine("The 'try catch' is finished.");
}
    }
}
