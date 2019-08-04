using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexNumber;

namespace ComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* * * Testing class complex number * * *");

            ComplexNumber num = new ComplexNumber(5, 7);
            ComplexNumber.PrintComplexNumber(num);
            num.AddComplexNumber(2, 6);
            ComplexNumber.PrintComplexNumber(num);
            num.SubtractComplexNumber(1, 1);
            ComplexNumber.PrintComplexNumber(num);
            num.MultiplyComplexNumber(2, 2);
            ComplexNumber.PrintComplexNumber(num);

            Console.WriteLine("* * * Part 2 - Operator Overloading * * *");
            ComplexNumber newNum = new ComplexNumber(5, 7);
            newNum = newNum + num;
            ComplexNumber.PrintComplexNumber(newNum);
            newNum = newNum - num;
            ComplexNumber.PrintComplexNumber(newNum);
            newNum = newNum * num;
            ComplexNumber.PrintComplexNumber(newNum);

            Console.ReadKey();
        }
    }
}
