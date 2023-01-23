using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naumov_SuperDuperProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle one = new Rectangle();
            Console.Write("ширина прямоугольника: ");
            one.length = Convert.ToDouble(Console.ReadLine());
            Console.Write("длина прямоугольника: ");
            one.width = Convert.ToDouble(Console.ReadLine());
            Rectangle.rect_calcule(one.length, one.width);
            Rectangle.rect_perim_calcule(one.length, one.width);
            Pair number = new Pair();
            Console.ReadLine();
        }
    }
    public class Rectangle : Pair
    {
        public double length;
        public double width;

        public static void rect_calcule(double x, double y)
        {
            Console.WriteLine("Площадь: " + x * y);
        }
        public static void rect_perim_calcule(double x, double y)
        {
            Console.WriteLine("Периметр: " + (2 * x + 2 * y));
        }

    }

    public class Pair
    {
        public double firstNumber;
        public double secondNumber;

        public static void multiply(double x, double y)
        {
            Console.WriteLine("Multiply: " + x * y);
        }
    }
}
