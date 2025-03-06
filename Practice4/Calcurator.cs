using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Calculate1
    {
        private double _x;
        private double _b;

        public Calculate1(double x, double b)
        {
            _x = x;
            _b = b;
        }
        public double CalculateA()
        {
            return Math.Log10(_x);
        }
        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Pow(a, 2) + Math.Sqrt(_b * _x);
        }
        public double CalculateY()
        {
            double c = CalculateC();
            return Math.Exp(2 * _x) + 9.7 * c;
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double c = CalculateC();
            double y = CalculateY();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"y = {y}");
        }
    }
        public class Calculate2
        {
            private double _x;
            private double _k;
        
         public Calculate2(double x, double k)
         {
                _x = x;
                _k = k;
         }
            public double CalculateA()
            {
                return Math.Abs(Math.Log10(_x));
            }
            public double CalculateY()
            {
                double a = CalculateA();
                double b = CalculateB();
                return _x * Math.Pow(a, 3) + Math.Pow(b, 2);
            }
            public double CalculateB()
            {
                double a = CalculateA();
                return Math.Exp(2 * _x) + a * _x;
            }
            public void DisplayResults()
            {
                double a = CalculateA();
                double b = CalculateB();
                double y = CalculateY();

                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                Console.WriteLine($"y = {y}");
            }
        } 
       public class Calculate3
       {
        private double _x;
        private double _p;
        public Calculate3(double x, double p)
        {
            _x = x;
            _p = p;
        }
        public double CalculateA()
        {
            return Math.Abs(Math.Log10(_x));
        }
        public double CalculateB()
        {
            return Math.Sin(Math.Pow(_p, 2)) + Math.Pow(_x, 3);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(a, 3) / Math.Pow(b, 2);
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"y = {y}");
        }

       }
    public class Calculate4
    {
        private double _x;
        private double _t;
        public Calculate4(double x, double t)
        {
            _x = x;
            _t = t;
        }
        public double CalculateA()
        {
            return Math.Log10(_x);
        }
        public double CalculateB()
        {
            return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_t, 2));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Sqrt(1 / 5 * Math.Abs(a - b * _x));
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"y = {y}");
        }

    }
    public class Calculate5
    {
        private double _p;
        private double _t;
        public Calculate5(double p, double t)
        {
            _p = p;
            _t = t;
        }
        public double CalculateK()
        {
            return Math.Sqrt(_p * _t);
        }
        public double CalculateX()
        {
            double k = CalculateK();
            return _p * Math.Pow(_t, 2) + Math.Sqrt(k);
        }
        public double CalculateY()
        {
            double k = CalculateK();
            double x = CalculateX();
            return Math.Pow(Math.Tan(Math.Pow(x, 2)),3 ) + k * _t;
        }
        public void DisplayResults()
        {
            double x = CalculateX();
            double y = CalculateY();
            double k = CalculateK();

            Console.WriteLine($"k = {k}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"x = {x}");
        }

    }
    public class Calculate6
    {
        private double _x;
        private double _m;
        public Calculate6(double x, double m)
        {
            _x = x;
            _m = m;
        }
        public double CalculateA()
        {
            return Math.Sqrt(Math.Abs(_x));
        }
        public double CalculateB()
        {
            return  Math.Pow(_x, 4) + Math.Pow(_m, 2);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(b), 3)), 2);
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double y = CalculateY();
            double b = CalculateB();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"b = {b}");
        }
    }
    public class Calculate7
    {
        private double _x;
        private double _k;
        public Calculate7(double x, double k)
        {
            _x = x;
            _k = k;
        }
        public double CalculateC() 
        {
            return Math.Sqrt(Math.Abs(_x));
        }
        public double CalculateA() 
        { 
            double c = CalculateC();

            return Math.Pow(c, 4) + Math.Pow(_k, 3);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double c = CalculateC();

            return Math.Pow(Math.Log10(a),3) + Math.Pow(Math.Cos(_x),5);
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double y = CalculateY();
            double c = CalculateC();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"c = {c}");
        }

    }
    public class Calculate8
    {
        private double _b;
        private double _c;
        public Calculate8(double b, double c)
        {
            _b = b;
            _c = c;
        }
        public double CalculateA()
        {
            return Math.Sin( _b );
        }
        public double CalculateX() 
        {
            double a = CalculateA();
            return a + Math.Pow((_b + _c), 2);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double x = CalculateX();

            return 7 * Math.Exp(Math.Sqrt(Math.Abs(x))) + Math.Pow(Math.Cos(x), 4);
        }

        public void DisplayResults()
        {
            double a = CalculateA();
            double y = CalculateY();
            double x = CalculateX();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"x = {x}");
        }


    }
    public class Calculate9
    {
        private double _k;
        private double _m;
        public Calculate9(double k, double m)
        {
            _k = k;
            _m = m;
        }

        public double CalculateY() 
        {
            double x = CalculateX();
            double c = CalculateC();

            return Math.Sqrt(1 / 3 * Math.Pow(x, 2) + Math.Pow(c, 2));
        }
        public double CalculateX() 
        {
            return Math.Exp(_m * _k);
        }
        public double CalculateC() 
        {
            return Math.Pow(Math.Cos(_m), 2) + Math.Pow(_k, 2);
        }
        public void DisplayResults()
        {
            double x = CalculateX();
            double c = CalculateC();
            double y = CalculateY();
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate10
    {
        private double _x;
        private double _b;
        public Calculate10(double x, double b)
        {
            _x = x;
            _b = b;
        }
        public double CalculateY()
        {
            return Math.Exp(_x + Math.Pow(5.8, 1));
        }
        public double CalculateA()
        {
            return Math.Pow(_b, 3) + Math.Log10(Math.Abs(_b));
        }
        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Pow(a, 2) + Math.Sqrt(_b);
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double y = CalculateY();
            double c = CalculateC();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"c = {c}");
        }

    }
    public class Calculate11
    {
        private double _x;
        private double _b;
        public Calculate11(double x, double b)
        {
            _x = x;
            _b = b;
        }
        public double CalculateA()
        {
            return Math.Pow(_b + _x, 3);
        }
        public double CalculateC()
        {
            return Math.Log10(Math.Abs(_b));
        }
        public double CalculateY()
        {
            double c = CalculateC();
            double a = CalculateA();
            return Math.Pow(c, 2) + Math.Sqrt(Math.Abs(a));
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double y = CalculateY();
            double c = CalculateC();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"c = {c}");
        }

    }
    public class Calculate12
    {
        private double _q;
        private double _b;
        public Calculate12(double q, double b)
        {
            _q = q;
            _b = b;
        }
        public double CalculateT()
        {
            return Math.Pow(_b, 3) + Math.Exp(Math.Sqrt(_q));
        }
        public double CalculateX()
        {
            double t = CalculateT();
            return Math.Pow(t, 3) + Math.Pow(_b, 2);
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Atan(Math.Pow(Math.Abs(x), 2));
        }
        public void DisplayResults()
        {
            double t = CalculateT();
            double y = CalculateY();
            double x = CalculateX();

            Console.WriteLine($"t = {t}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"x = {x}");
        }
    }
    public class Calculate13
    {
        private double _x;
        private double _a;
        public Calculate13(double x, double a)
        {
            _x = x;
            _a = a;
        }
        public double CalculateW()
        {
            return Math.Pow(_x, 2) * Math.Sqrt(Math.Abs(_a + _x));
        }
        public double CalculateZ()
        {
            double w = CalculateW();
            return Math.Cos(Math.Pow(_a, 2)) + Math.Pow(w, 2);
        }
        public double CalculateY()
        {
            double z = CalculateZ();
            double w = CalculateW();
            return _a * Math.Pow(z, 7) + Math.Sin(Math.Pow(w, 2));
        }
        public void DisplayResults()
        {
            double w = CalculateW();
            double z = CalculateZ();
            double y = CalculateY();

            Console.WriteLine($"w = {w}");
            Console.WriteLine($"z = {z}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate14
    {
        private double _b;
        private double _k;
        public Calculate14(double b, double k)
        {
            _b = b;
            _k = k;
        }
        public double CalculateT()
        {
            return Math.Pow(_b, 2) + Math.Pow(_k, 3);
        }
        public double CalculateA()
        {
            double t = CalculateT();
            return Math.Sqrt(_b + t);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Sin(Math.Pow(Math.Pow(a, 2) + Math.Pow(_b, 2), 3));
        }
        public void DisplayResults()
        {
            double t = CalculateT();
            double a = CalculateA();
            double y = CalculateY();

            Console.WriteLine($"t = {t}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate15
    {
        private double _a;
        private double _p;
        public Calculate15(double a, double p)
        {
            _a = a;
            _p = p;
        }
        public double CalculateX()
        {
            double b = CalculateB();
            return Math.Exp(b);
        }
        public double CalculateB()
        {
            return Math.Abs(_a) + Math.Sqrt(_a + Math.Pow(_p, 2));
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Cos(Math.Pow(x, 3)) + Math.Abs(_a);
        }
        public void DisplayResults()
        {
            double x = CalculateX();
            double y = CalculateY();
            double b = CalculateB();

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"b = {b}");
        }
    }
    public class Calculate16
    {
        private double _x;
        private double _c;
        public Calculate16(double x, double c)
        {
            _x = x;
            _c = c;
        }
        public double CalculateB()
        {
            return _x + Math.Pow(_c, 2);
        }
        public double CalculateA()
        {
            double b = CalculateB();
            return Math.Sqrt(1 / 3 * Math.Abs(b + _c));
        }
        public double CalculateY()
        {
            double b = CalculateB();
            double a = CalculateA();
            return Math.Cos(Math.Pow(b, 2)) + b * Math.Cos(Math.Pow(Math.Pow(a, 2), 3));
        }
        public void DisplayResults()
        {
            double b = CalculateB(); 
            double a = CalculateA();
            double y = CalculateY();

            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
        }

    }
    public class Calculate17
    {
        private double _x;
        private double _t;
        public Calculate17(double x, double t)
        {
            _x = x;
            _t = t;
        }
        public double CalculateB()
        {
            return Math.Log10(Math.Pow(Math.Abs(_x), 2));
        }
        public double CalculateA()
        {
            double b = CalculateB();
            return _t * _x + Math.Abs(Math.Sqrt(b));
        }
        public double CalculateY()
        {
            double b = CalculateB();
            double a = CalculateA();
            return Math.Pow(Math.Cos(a + Math.Pow(b, 3)), 3); 
        }
        public void DisplayResults()
        {
            double b = CalculateB();
            double a = CalculateA();
            double y = CalculateY();

            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate18
    {
        private double _x;
        private double _b;
        public Calculate18(double x, double b)
        {
            _x = x;
            _b = b;
        }
        public double CalculateA()
        {
            return Math.Sqrt(Math.Abs(_x)) + Math.Exp(Math.Sqrt(_b));
        }
        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Log10(a) + Math.Pow(_b, 2);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double c = CalculateC();
            return Math.Pow(a, 3) / Math.Cos(c);
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double c = CalculateC();
            double y = CalculateY();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"y = {y}");
        }

    }
    public class Calculate19
    {
        private double _x;
        private double _a;
        public Calculate19(double x, double a)
        {
            _x = x;
            _a = a;
        }
        public double CalculateT()
        {
            return Math.Pow(_x, 2) + Math.Pow(_a, 2);
        }
        public double CalculateP()
        {
            return Math.Pow(_x, 2) - Math.Sqrt(Math.Abs(_x));
        }
        public double CalculateY()
        {
            double p = CalculateP();
            double t = CalculateT();
            return _x * Math.Pow(p, 2) + Math.Pow(t, 5);
        }
        public void DisplayResults()
        {
            double t = CalculateT();
            double p = CalculateP();
            double y = CalculateY();

            Console.WriteLine($"t = {t}");
            Console.WriteLine($"p = {p}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate20
    {
        private double _x;
        private double _p;
        public Calculate20(double x, double p)
        {
            _x = x;
            _p = p;
        }
        public double CalculateA()
        {
            return Math.Log10(Math.Abs(_x));
        }
        public double CalculateB()
        {
            return Math.Pow(_x, 4) + Math.Log10(Math.Pow(_p, 3));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Sin(Math.Pow(a, 3)) * _x + Math.Sqrt(b) * Math.Cos(Math.Pow(_x, 2));
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double b = CalculateB();
            double y = CalculateY();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate21
    {
        private double _n;
        private double _b;
        public Calculate21(double n, double b)
        {
            _n = n;
            _b = b;
        }
        public double CalculateX()
        {
            return Math.Pow(_n, _b) + Math.Pow(_b, 2);
        }
        public double CalculateA()
        {
            double x = CalculateX();
            return Math.Sin(Math.Pow(x, 2) + Math.Pow(_b, 2));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Log10(a) / Math.Log10(Math.Pow(_b, 3));
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double x = CalculateX();
            double y = CalculateY();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate22
    {
        private double _m;
        private double _p;
        public Calculate22(double m, double p)
        {
            _m = m;
            _p = p;
        }
        public double CalculateT()
        {
            return Math.Sin(Math.Pow(_m, 3));
        }
        public double CalculateX()
        {
            double t = CalculateT();
            return Math.Pow(_p, 2) + t;
        }
        public double CalculateY()
        {
            double t = CalculateT();
            double x = CalculateX();
            return Math.Log10(Math.Pow(Math.Abs(x + t), 4));
        }
        public void DisplayResults()
        {
            double t = CalculateT();
            double x = CalculateX();
            double y = CalculateY();

            Console.WriteLine($"t = {t}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }

    }
    public class Calculate23
    {
        private double _b;
        private double _x;
        public Calculate23(double x, double b)
        {
            _x = x;
            _b = b;
        }
        public double CalculateT()
        {
            return _x * Math.Pow(_b, 2) + Math.Sqrt(_x);
        }
        public double CalculateA()
        {
            double t = CalculateT();
            return Math.Log10(Math.Abs(t * _x + Math.Pow(_b, 2)));
        }
        public double CalculateY()
        {
            double t = CalculateT();
            double a = CalculateA();
            return Math.Log(a + _b) + (Math.Pow(a, 2)) / (a + t); 
        }
        public void DisplayResults()
        {
            double t = CalculateT();
            double a = CalculateA();
            double y = CalculateY();

            Console.WriteLine($"t = {t}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
        }

    }
    public class Calculate24
    {
        private double _b;
        private double _t;
        public Calculate24(double b, double t)
        {
            _b = b;
            _t = t;
        }
        public double CalculateA()
        {
            return Math.Pow(_t, 2) * _b;
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Pow(a, 3) + Math.Sqrt(_t + _b);
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Cos(Math.Pow(x, 5)) - _b * Math.Pow(Math.Sin(x), 2);
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double x = CalculateX();
            double y = CalculateY();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }

    }
    public class Calculate25
    {
        private double _a;
        private double _p;
        public Calculate25(double a, double p)
        {
            _a = a;
            _p = p;
        }
        public double CalculateT()
        {
            return Math.Pow(_p, 3) + Math.Pow(_a, 3);
        }
        public double CalculateX()
        {
            return Math.Exp(_p + _a);
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double t = CalculateT();
            return Math.Pow(x, 3) / Math.Pow(t, 2);
        }
        public void DisplayResults()
        {
            double t = CalculateT();
            double x = CalculateX();
            double y = CalculateY();

            Console.WriteLine($"t = {t}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate26
    {
        private double _b;
        private double _t;
        public Calculate26(double b, double t)
        {
            _b = b;
            _t = t;
        }
        public double CalculateA()
        {
            return Math.Sqrt(_b + Math.Pow(_t, 2));
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Cos(Math.Pow(_b, 2)) + Math.Sin(Math.Pow(a, 2));
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Pow(x, 2) + Math.Sqrt(1/3 * Math.Abs(x));
        }
        public void DisplayResults()
        {
            double a = CalculateA();
            double x = CalculateX();
            double y = CalculateY();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate27
    {
        private double _a;
        private double _t;
        public Calculate27(double a, double t)
        {
            _a = a;
            _t = t;
        }
        public double CalculateC()
        {
            return Math.Pow(_t, 2) + Math.Sqrt(_a);
        }
        public double CalculateX()
        {
            double c = CalculateC();
            return Math.Log(Math.Abs(c * _t)) + Math.Pow(_a, 2);
        }
        public double CalculateY()
        {
            double x = CalculateX();
            return Math.Tan(4 * x) + Math.Sin(Math.Pow(x, 2));
        }
        public void DisplayResults()
        {
            double c = CalculateC();
            double x = CalculateX();
            double y = CalculateY();

            Console.WriteLine($"c = {c}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate28
    {
        private double _b;
        private double _k;
        public Calculate28(double b, double k)
        {
            _b = b;
            _k = k;

        }
        public double CalculateT()
        {
            return Math.Pow(_k, 2) + Math.Sqrt(_b);
        }
        public double CalculateA()
        {
            double t = CalculateT();
            return _b + Math.Pow(t, 2) * Math.Exp(t);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Pow(Math.Cos(Math.Pow(a, 3) + _b), 4);
        }
        public void DisplayResults()
        {
            double t = CalculateT();
            double a = CalculateA();
            double y = CalculateY();

            Console.WriteLine($"t = {t}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate29
    {
        private double _a;
        private double _b;
        public Calculate29(double a, double b)
        {
            _a = a;
            _b = b;
        }
        public double CalculateX()
        {
            return Math.Exp(2 * _a) + Math.Sqrt(_b);
        }
        public double CalculateP()
        {
            double x = CalculateX();
            return x * (_a + Math.Pow(_b, 3));
        }
        public double CalculateY()
        {
            double p = CalculateP();
            double x = CalculateX();
            return Math.Log10(Math.Pow(Math.Abs(p), 3)) + x;
        }
        public void DisplayResults()
        {
            double x = CalculateX();
            double p = CalculateP();
            double y = CalculateY();

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"p = {p}");
            Console.WriteLine($"y = {y}");
        }
    }
    public class Calculate30
    {
        private double _b;
        private double _t;
        public Calculate30(double b, double t)
        {
            _b = b;
            _t = t;
        }
        public double CalculateA()
        {
            return _t + Math.Pow(_b, 3);
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Pow(_t, 2) * Math.Sqrt(Math.Abs(a + _b));
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double a = CalculateA();
            return Math.Pow(Math.Log(Math.Abs(x + Math.Pow(a, 2))), 5);
        }
        public void DisplayResults()
        {
            double x = CalculateX();
            double a = CalculateA();
            double y = CalculateY();

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");
        }
    }

}
