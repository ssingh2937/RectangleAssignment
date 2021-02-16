using System;

namespace RectangleAssignment
{ 
    class Program
    {
       
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the length of rectangle");
            int length = Convert.ToInt32(Console.ReadLine());
            rectangle.setLength(length);

            Console.WriteLine("Enter the width of rectangle");
            int width = Convert.ToInt32(Console.ReadLine());
            rectangle.setWidth(width);

          
            if (length < 1 || width < 1)
            {
                Console.WriteLine("Length or width can never be less than 1.");
            } else {

                Console.WriteLine("\n\n Select operation from the menu");

                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");

                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("Length of the rectangle is: " + rectangle.GetLength().ToString());
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Enter new length value");
                    length = Convert.ToInt32(Console.ReadLine());
                    rectangle.setLength(length);

                    Console.WriteLine("Length of the rectangle is: " + rectangle.GetLength().ToString());
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Width of the rectangle is: " + rectangle.GetWidth().ToString());
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Enter new width value");
                    width = Convert.ToInt32(Console.ReadLine());
                    rectangle.setWidth(width);

                    Console.WriteLine("Width of the rectangle is: " + rectangle.GetWidth().ToString());
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("Perimeter of the rectangle is = " + rectangle.GetPerimeter().ToString());
                }
                else if (userInput == 6)
                {
                    Console.WriteLine("Area of the rectangle is = " + rectangle.GetArea().ToString());
                }
                else if (userInput == 7)
                {
                    Console.Clear();
                    System.Environment.Exit(0); 
                }


                

            }

        }
    }
}
