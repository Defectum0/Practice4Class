using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №4");
            Console.WriteLine("Введите номер задания от 1 до 30");
            Thread.Sleep(2000);
            Console.Clear();
            switch (Console.ReadLine())
            {

                default:
                case "1":
                    Calculate1();
                    break;
                case "2":
                    Calculate2();
                    break;
                case "3":
                    Calculate3();
                    break;
                case "4":
                    Calculate4();
                    break;
                case "5":
                    Calculate5();
                    break;
                case "6":
                    Calculate6();
                    break;
                case "7":
                    Calculate7();
                    break;
                case "8":
                    Calculate8();
                    break;
                case "9":
                    Calculate9();
                    break;
                case "10":
                    Calculate10();
                    break;
                case "11":
                    Calculate11();
                    break;
                case "12":
                    Calculate12();
                    break;
                case "13":
                    Calculate13();
                    break;
                case "14":
                    Calculate14();
                    break;
                case "15":
                    Calculate15();
                    break;
                case "16":
                    Calculate16();
                    break;
                case "17":
                    Calculate17();
                    break;
                case "18":
                    Calculate18();
                    break;
                case "19":
                    Calculate19();
                    break;
                case "20":
                    Calculate20();
                    break;
                case "21":
                    Calculate21();
                    break;
                case "22":
                    Calculate22();
                    break;
                case "23":
                    Calculate23();
                    break;
                case "24":
                    Calculate24();
                    break;
                case "25":
                    Calculate25();
                    break;
                case "26":
                    Calculate26();
                    break;
                case "27":
                    Calculate27();
                    break;
                case "28":
                    Calculate28();
                    break;
                case "29":
                    Calculate29();
                    break;
                case "30":
                    Calculate30();
                    break;                   

            }
        }
        public static void Calculate1()
        {
            double x = 3.5;
            double b = 0.4;

            Calculate1 calculate1 = new Calculate1(x, b);
            calculate1.DisplayResults();
        }
        public static void Calculate2()
        {
            double x = 1.3;
            double k = 0.4;

            Calculate2 calculate2 = new Calculate2(x, k);
            calculate2.DisplayResults();
        }
        public static void Calculate3()
        {
            double x = 2.1;
            double p = 1;

            Calculate3 calculate3 = new Calculate3(x, p);
            calculate3.DisplayResults();
        }
        public static void Calculate4()
        {
            double x = 2.7;
            double t = -6;

            Calculate4 calculate4 = new Calculate4(x, t);
            calculate4.DisplayResults();
        }
        public static void Calculate5()
        {
            double t = 4.1;
            double p = 3;

            Calculate5 calculate5 = new Calculate5(t, p);
            calculate5.DisplayResults();
        }
        public static void Calculate6()
        {
            double m = 2;
            double x = 1.1;

            Calculate6 calculate6 = new Calculate6(m, x);
            calculate6.DisplayResults();
        }
        public static void Calculate7()
        {
            double x = 5;
            double k = 8.2;

            Calculate7 calculate7 = new Calculate7(x, k);
            calculate7.DisplayResults();
        }
        public static void Calculate8()
        {
            double b = 2.2;
            double c = 3.7;

            Calculate8 calculate8 = new Calculate8(b, c);
            calculate8.DisplayResults();
        }
        public static void Calculate9()
        {
            double m = 1.8;
            double k = 1;

            Calculate9 calculate9 = new Calculate9(m, k);
            calculate9.DisplayResults();
        }
        public static void Calculate10()
        {
            double x = 2.8;
            double b = 1.3;

            Calculate10 calculate10 = new Calculate10(x, b);
            calculate10.DisplayResults();
        }
        public static void Calculate11()
        {
            double b = 7;
            double x = 2;

            Calculate11 calculate11 = new Calculate11(x, b);
            calculate11.DisplayResults();
        }
        public static void Calculate12()
        {
            double q = 2;
            double b = 1.8;

            Calculate12 calculate12 = new Calculate12(q, b);
            calculate12.DisplayResults();
        }
        public static void Calculate13()
        {
            double a = -0.9;
            double x = 1.9;

            Calculate13 calculate13 = new Calculate13(x, a);
            calculate13.DisplayResults();
        }
        public static void Calculate14()
        {
            double b = 6;
            double k = 3.4;

            Calculate14 calculate14 = new Calculate14(k, b);
            calculate14.DisplayResults();
        }
        public static void Calculate15()
        {
            double a = 5.5;
            double p = 4;

            Calculate15 calculate15 = new Calculate15(a, p);
            calculate15.DisplayResults();
        }
        public static void Calculate16()
        {
            double c = 9;
            double x = 8.52;

            Calculate16 calculate16 = new Calculate16(x, c);
            calculate16.DisplayResults();
        }
        public static void Calculate17()
        {
            double t = 2;
            double x = 0.9;

            Calculate17 calculate17 = new Calculate17(x, t);
            calculate17.DisplayResults();
        }
        public static void Calculate18()
        {
            double b = 9.5;
            double x = -8;

            Calculate18 calculate18 = new Calculate18(x, b);
            calculate18.DisplayResults();
        }
        public static void Calculate19()
        {
            double a = 3.7;
            double x = 4;

            Calculate19 calculate19 = new Calculate19(x, a);
            calculate19.DisplayResults();
        }
        public static void Calculate20()
        {
            double x = 1.4;
            double p = 1.6;

            Calculate20 calculate20 = new Calculate20(x, p);
            calculate20.DisplayResults();
        }
        public static void Calculate21()
        {
            double b = 1.6;
            double n = 8.1;

            Calculate21 calculate21 = new Calculate21(n, b);
            calculate21.DisplayResults();
        }
        public static void Calculate22()
        {
            double m = 5.7;
            double p = 4;

            Calculate22 calculate22 = new Calculate22(m, p);
            calculate22.DisplayResults();
        }
        public static void Calculate23()
        {
            double b = 0.3;
            double x = 5.2;

            Calculate23 calculate23 = new Calculate23(x, b);
            calculate23.DisplayResults();
        }
        public static void Calculate24()
        {
            double b = 1.8;
            double t = 6.2;

            Calculate24 calculate24 = new Calculate24(t, b);
            calculate24.DisplayResults();
        }
        public static void Calculate25()
        {
            double a = 2;
            double p = 2.6;

            Calculate25 calculate25 = new Calculate25(a, p);
            calculate25.DisplayResults();
        }
        public static void Calculate26()
        {
            double b =8.1;
            double t = 2;

            Calculate26 calculate26 = new Calculate26(t, b);
            calculate26.DisplayResults();
        }
        public static void Calculate27()
        {
            double t = -3;
            double a = 76;

            Calculate27 calculate27 = new Calculate27(t, a);
            calculate27.DisplayResults();
        }
        public static void Calculate28()
        {
            double b = 2.19;
            double k = 1.7;

            Calculate28 calculate28 = new Calculate28(k, b);
            calculate28.DisplayResults();
        }
        public static void Calculate29()
        {
            double b = 4.3;
            double a = 6;

            Calculate29 calculate29 = new Calculate29(a, b);
            calculate29.DisplayResults();
        }
        public static void Calculate30()
        {
            double t = 3;
            double b = 4.2;

            Calculate30 calculate30 = new Calculate30(t, b);
            calculate30.DisplayResults();
        }
    } 
}
