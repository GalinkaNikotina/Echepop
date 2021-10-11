using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drobi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое дробное число");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе дробное число");
            int q = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            Drob a = new Drob(x, y);
            Drob b = new Drob(q, f);
            Drob c;
            c = a + b;
            Console.WriteLine("Проверка на сложение: " + a.ToString() + '+' + b.ToString() + '=' + c.ToString());
            c = a - b;
            Console.WriteLine("Проверка на вычитание: " + a.ToString() + '-' + b.ToString() + '=' + c.ToString());
            c = a * b;
            Console.WriteLine("Проверка на умножденеи: " + a.ToString() + '*' + b.ToString() + '=' + c.ToString());
            c = a / b;
            Console.WriteLine("Проверка на деление: " + a.ToString() + '/' + b.ToString() + '=' + c.ToString());
            Console.ReadKey();
           
            
        }
        class Drob
        {
            public double c = 0;
            public double z = 0;
            public Drob(int c, int z)
            {
                this.c = c;
                this.z = z;
            }
            public override string ToString()
            {
                return "(" + c.ToString() + '/' + z.ToString() + ")";
            }
            public static Drob operator +(Drob a, Drob b)
            {
                Drob t = new Drob(1, 1);
                t.c = (a.c * b.z + a.z * b.c);
                t.z = a.z * b.z;
                Drob.SetFormat(t);
                return t;
            }
            public static Drob operator -(Drob a, Drob b)
            {
                Drob t = new Drob(1, 1);
                t.c = (a.c * b.z - a.z * b.c);
                t.z = a.z * b.z;
                Drob.SetFormat(t);
                return t;
            }
            public static Drob operator *(Drob a, Drob b)
            {
                Drob t = new Drob(1, 1);
                t.c = (a.c * b.c);
                t.z = a.z * b.z;
                Drob.SetFormat(t);
                return t;
            }
            public static Drob operator /(Drob a, Drob b)
            {

                Drob t = new Drob(1, 1);
                t.c = (a.c / b.c);
                t.z = a.z / b.z;
                Drob.SetFormat(t);
                return t;
            }

            public static Drob SetFormat(Drob a)
            {
                double max = 0;

                if (a.c > a.z)
                    max = Math.Abs(a.z);
                else
                    max = Math.Abs(a.c);
                for (double i = max; i >= 2; i--)
                {
                    if ((a.c % i == 0) & (a.z % i == 0))
                    {
                        a.c = a.c / i;
                        a.z = a.z / i;
                    }
                }

                if ((a.z < 0))
                {
                    a.c = -1 * (a.c);
                    a.z = Math.Abs(a.z);
                }
                return (a);
            }

        }

       
          
    }
}