using System;

namespace Line_Comp_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program");
            //Declaring Co-ordinates for the End-Points of line to calculate length
            int x1, x2, y1, y2, x3, x4, y3, y4;
            double length_One, length_Two;
            x1 = 4; x3 = 4;
            y1 = 1; y3 = 1;
            x2 = 1; x4 = 1;
            y2 = 3; y4 = 3;

            //logic to calculate length
            int resultone = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2);//you can use Math.sqrt() function for this
            length_One = Math.Abs((0.5) * resultone);//Math.Abs is for making value positive if it is negative
            //By Math.sqrt() method
            //length_One = Math.Sqrt(Math.Abs(resultone)); //by using sqrt method
            Console.WriteLine("Length Of the coordinates ({0},{1}) and ({2},{3}) is : {4}", x1, y1, x2, y2, length_One);

            int resulttwo = ((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            length_Two = Math.Abs((0.5) * resulttwo);
            Console.WriteLine("Length Of the coordinates ({0},{1}) and ({2},{3}) is : {4}", x3, y3, x4, y4, length_Two);

            //Comparison with Equals method
            Console.WriteLine("Equals() Method : "+length_One.Equals(length_Two));

            //CompareTo method for checking lengths
            Console.WriteLine("CompareTo() Method : " + length_One.CompareTo(length_Two));
        }
    }
}
