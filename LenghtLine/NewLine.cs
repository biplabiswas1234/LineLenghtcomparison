using System;

namespace LineComparing
{
    internal class Program
    {
        public double LenghtOfLine()
        {
            Console.WriteLine("Enter the cartesian coordinates of  (x1,y1)");
            //Console.WriteLine("Enter the cartesian coordinates of  (x1,y1)");
            //Console.WriteLine("Enter the cartesian coordinates of  (x1,y1)");
            //Console.WriteLine("Enter the cartesian coordinates of  (x1,y1)");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cartesian coordinates of (x2,y2)");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double Lenght = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return Lenght;
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            double Lenght1 = obj1.LenghtOfLine();
            double Lenght2 = obj1.LenghtOfLine();

            Console.WriteLine("The lenght of the two points of line-1: " + Lenght1);
            Console.WriteLine("The lenght of the two points of line-2: " + Lenght2);
            if (Lenght1 < Lenght2)
            {
                Console.WriteLine("Line-1 is less than line-2");
            }
            else
            {
                if (Lenght2 < Lenght1)
                {
                    Console.WriteLine("Line-1 is Greater than line-2");
                }
                else
                {
                    Console.WriteLine("Line-1 is equal to line-2");
                }
            }

        }
    }
}
