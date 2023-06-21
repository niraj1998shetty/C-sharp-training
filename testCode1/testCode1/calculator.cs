using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCode1
{
    internal class calculator
    {
        double result = 0;

            switch (operatorName)
            {
                case "+":
                    result = firstNo + secondNo;
                    break;
                case "-":
                    result = firstNo - secondNo;
                    break;
                case "*":
                    result = firstNo* secondNo;
                    break;
                case "/":
                    result = firstNo / secondNo;
                    break;
                default:
                    Console.WriteLine("Invalid operator entered.");
                    break;
            }

            return result;
    }
}
