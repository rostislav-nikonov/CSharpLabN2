using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLab
{
    internal class Fractions
    {
        private int numerator;
        private int denominator;


        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;              
            }
        }

        public Fractions(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fractions Sum(Fractions other)
        {
            int numerator = this.Numerator * other.Denominator + other.Numerator * this.Denominator;
            int denominator = this.Denominator * other.Denominator;
            return new Fractions(numerator, denominator);
        }  

        public Fractions Mult(Fractions other)
        {
            int numerator = this.Numerator * other.Numerator;
            int denominator = this.Denominator * other.Denominator;
            return new Fractions(numerator, denominator);
        }

        public Fractions Minus(Fractions other)
        {
            int numerator = this.Numerator * other.Denominator - other.Numerator * this.Denominator;
            int denominator = this.Denominator * other.Denominator;
            return new Fractions(numerator, denominator);
        }

        //Перегрузка
        public Fractions Minus(int number)
        {
            Fractions fraction = new Fractions(number, 1);
            return this.Minus(fraction);
        }

        public Fractions Div(Fractions other)
        {
            int numerator = this.Numerator * other.Denominator;
            int denominator = this.Denominator * other.Numerator;
            return new Fractions(numerator, denominator);
        }

        public Fractions Reduce()
        {
            int numerator = this.Numerator;
            int denominator = this.Denominator;
           
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            return new Fractions(numerator, denominator);
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }
}


