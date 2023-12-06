using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            //1
            int justInt = 100;
            double a = (justInt + 13) / 2;
            float c = (float)(a + 10);
            string myString = "abraCadabra";
            char b = 's';
            myString += b;
            bool b1 = true;
            bool b2 = !b1;

            Console.WriteLine(justInt);
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(myString);
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine();
            Console.WriteLine(int.MaxValue + " - int max value");
            Console.WriteLine(int.MinValue + " - int min value");
            Console.WriteLine(double.MaxValue + " - double max value");
            Console.WriteLine(double.MinValue + " - double min value");
            Console.WriteLine(float.MaxValue + " - float max value");
            Console.WriteLine(float.MinValue + " - float min value");
            Console.WriteLine(long.MaxValue + " - longint max value");
            Console.WriteLine(long.MinValue + " - longint min value");
            Console.WriteLine(byte.MaxValue + " - byte max value");
            Console.WriteLine(byte.MinValue + " - byte min value");
            Console.WriteLine(decimal.MaxValue + " - decimal max value");
            Console.WriteLine(decimal.MinValue + " - decimal min value");
            Console.WriteLine(short.MaxValue + " - short max value");
            Console.WriteLine(ushort.MaxValue + " - ushort max value");
            Console.WriteLine(uint.MaxValue + " - uint max value");
            Console.WriteLine(ulong.MaxValue + " - ulong max value");

            Console.ReadLine();





            //2

            int leftBorder, rightBorder;
            Console.WriteLine("Enter the borders");
            leftBorder = Convert.ToInt32(Console.ReadLine());
            rightBorder = Convert.ToInt32(Console.ReadLine());

            for (int i = leftBorder; i <= rightBorder; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i + " - chetnoe");
                else
                    Console.WriteLine(i + " - nechetnoe");
            }
            Console.WriteLine();

            int temp = leftBorder;

            while (temp <= rightBorder)
            {
                if (temp % 2 == 0)
                    Console.WriteLine(temp + " - chetnoe");
                else
                    Console.WriteLine(temp + " - nechetnoe");
                temp++;
            }

            Console.WriteLine();


            do
            {
                if (leftBorder % 2 == 0)
                    Console.WriteLine(leftBorder + " - chetnoe");
                else
                    Console.WriteLine(leftBorder + " - nechetnoe");
                leftBorder++;
            }
            while (leftBorder <= rightBorder);

            Console.Read();





            int a3 = 5, b3 = 10;

            int myFunc (int x, int y)
            {
                x *= 2;
                y *= 3;
                return x + y;
            }

            Console.WriteLine(myFunc(a3, b3) + " " + a3  + " " + b3);

            int myFuncRef(ref int x, ref int y)
            {
                x *= 2;
                y *= 3;
                return x + y;
            }

            Console.WriteLine(myFuncRef(ref a3, ref b3) + " " + a3 + " " + b3);

            Console.Read();
        }
    }
}
