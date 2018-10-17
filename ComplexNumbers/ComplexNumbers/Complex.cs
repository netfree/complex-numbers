using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Complex
    {
        private int _a;
        private int _b;

        public int A
        {
            set
            {
                _a = value;
            }

            get
            {
                return _a;
            }
        }
        public int B
        {
            set
            {
                _b = value;
            }

            get
            {
                return _b;
            }
        }

        public Complex(int a, int b)
        {
            A = a;
            B = b;
        }

        public Complex()
        {
            A = 0;
            B = 0;
        }

        public double Modulus()
        {
            return Math.Sqrt(A * A + B * B);
        }

        public static Complex operator+ (Complex x, Complex y)
        {
            var xPlusY = new Complex();
            xPlusY.A = x.A + y.A;
            xPlusY.B = x.B + y.B;
            return xPlusY;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            var xPlusY = new Complex();
            xPlusY.A = x.A - y.A;
            xPlusY.B = x.B - y.B;
            return xPlusY;
        }

        private string Sign(int a)
        {
            if (a < 0)
                return "-";
            return "+";
        }

        public override string ToString()
        {
            if (B == 0)
                return A.ToString();

            return this.A.ToString() + Sign(B) + this.B.ToString() + "i";
        }
       

    }
}
