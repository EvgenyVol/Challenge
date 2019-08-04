using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class ComplexNumber
    {
        float Re;

        float Im;

        public ComplexNumber(float re, float im)
        {
            Re = re;
            Im = im;
        }

        public static void PrintComplexNumber(ComplexNumber number)
        {
            Console.WriteLine(number.Re + " + " + number.Im + "i");
        }

        public void AddComplexNumber(float re, float im)
        {
            Re += re;
            Im += im;
        }

        public void SubtractComplexNumber(float re, float im)
        {
            Re -= re;
            Im -= im;
        }

        public void MultiplyComplexNumber(float re, float im)
        {
            Re *= re;
            Im *= im;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            a.Re = a.Re + b.Re;
            a.Im = a.Im + b.Im;

            return a;
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            a.Re = a.Re - b.Re;
            a.Im = a.Im - b.Im;

            return a;
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            a.Re = a.Re * b.Re;
            a.Im = a.Im * b.Im;

            return a;
        }
    }
}
