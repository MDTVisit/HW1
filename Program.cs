using System;

class Program {
    static void Main(string[] args) {
	double x1 , x2 , x3;
	double y1 , y2 , y3; 

         x1 = Convert.ToDouble(Console.ReadLine());
		 y1 = Convert.ToDouble(Console.ReadLine());
         x2 = Convert.ToDouble(Console.ReadLine());
		 y2 = Convert.ToDouble(Console.ReadLine());
		 x3 = Convert.ToDouble(Console.ReadLine());
		 y3 = Convert.ToDouble(Console.ReadLine());

   
		double Center = (y2 - y1) * (Math.Pow(y3,2) - Math.Pow(y1,2) + Math.Pow(x3,2) - Math.Pow(x1,2))  + (y3 - y1) * (Math.Pow(y1,2) - Math.Pow(y2,2) + Math.Pow(x1,2) - Math.Pow(x2,2)) / (2 * (x3 - x1) * (y2 - y1) - 2 * (x2 - x1) * (y3 - y1));
        double Center2 =  (x2 - x1) * (Math.Pow(x3,2) - Math.Pow(x1,2) + Math.Pow(y3,2) - Math.Pow(y1,2))  + (x3 - x1) * (Math.Pow(x1,2) -  Math.Pow(x2,2) + Math.Pow(y1,2) - Math.Pow(y2,2)) / (2 * (y3 - y1) * (x2 - x1) - 2 * (y2 - y1) * (x3 - x1));

        double r = Math.Sqrt (Math.Pow(x1-Center,2) + Math.Pow(y1-Center2,2));

        Console.WriteLine("Center: ({0}, {1})", Center, Center2);
        Console.WriteLine("Radius: {0}", r);

        Console.ReadKey();
    }
}
