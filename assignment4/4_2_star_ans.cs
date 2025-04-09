using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            for (int i = 0; i <= 2 * radius; i++)
            {
                if (i == 0 || i == 2 * radius)
                {
                    Console.Write(" ");
                    for (int j = 1; j <= 2 * radius; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                    for (int c = 0; c <= 2 * radius; c++)
                    {
                        if (c == 2 * radius / 3 || c == 4 * radius / 3)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");

                }
                else if (i == 2 * radius / 3 || i == 4 * radius / 3)
                {
                    Console.Write("*");
                    for (int a = 1; a <= size; a++)
                    {
                        Console.Write(" ");
                    }
                    for (int b = 1; b < 2 * radius; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("*");
                    for (int d = 1; d < 2 * radius; d++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("  ");
                    for (int c = 0; c <= 2 * radius; c++)
                    {
                        if (c == 2 * radius / 3 || c == 4 * radius / 3)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine("");
                }
            }
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/