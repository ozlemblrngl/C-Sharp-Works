using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int selection;

    
        do
        {
            WriteMenu();
            bool result;

            do
            {
                Console.Write("SELECT: ");

                string selectionStr = Console.ReadLine();
                result = int.TryParse(selectionStr, out selection);

            }
            while ( result == false);

            SwitchCaseOpr(selection);
        }
        while (selection != 0);

    }

    static void WriteMenu()
    {
        Console.Clear();

        DrawLine("Area Calculation Application");
        
        Console.WriteLine();

        DrawLine("MENU");
        Console.WriteLine("1- Area of Square Calculation");
        Console.WriteLine("2- Area of Rectangle Calculation");
        Console.WriteLine("3- Area of Trapezoid Calculation");
        Console.WriteLine("0- Exit");
        Console.WriteLine();
    }

    static void DrawLine(string title)
    {
        Console.WriteLine(title);

        for (int i = 0; i < title.Length; i++) 
        {
            Console.Write("-");
        }
        Console.WriteLine();
        Console.WriteLine();

    }

    static void SquareArea()
    {

        Console.Clear();

        DrawLine("Area of Square");

        int a;
        bool result;

        do
        {
            Console.WriteLine("Please enter lenght of side as cm: ");

            string aStr = Console.ReadLine();
            result = int.TryParse(aStr, out a);

        }
        while (result == false);

        Console.WriteLine();
        Console.WriteLine("Result: " + a * a);
        Continue();
    }

    static void RectangleArea()
    {
        Console.Clear();

        DrawLine("Area of Rextangle");

        bool result;
        int a, b;

        do
        {

            Console.WriteLine("Please enter lenght of shortside as cm: ");

            string aStr = Console.ReadLine();
            result = int.TryParse(aStr, out a);

        }
        while (result == false);


        do
        {
            Console.WriteLine("Please enter lenght of longside as cm: ");

            string bStr = Console.ReadLine();
            result = int.TryParse(bStr, out b);

        }
        while (result == false);

        Console.WriteLine();
        Console.WriteLine("Result: " + a * b);
        Continue();
    }

    static void Continue()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter any button");
        Console.ReadKey();
        Console.WriteLine();
    }

    static void TriangleArea()
    {
        Console.Clear();

        DrawLine("Area of Rextangle");

        bool result;
        int a, h;

        do
        {

            Console.WriteLine("Please enter lenght of side as cm: ");
            string aStr = Console.ReadLine();
            result = int.TryParse(aStr, out a);

        }
        while (result == false);


        do
        {
            Console.WriteLine("Please enter lenght of height as cm: ");

            string hStr = Console.ReadLine();
            result = int.TryParse(hStr, out h);

        }
        while (result == false);

        double aDouble = Convert.ToDouble(a);
        double hDouble = Convert.ToDouble(h);



        Console.WriteLine();
        Console.WriteLine("Result: " + (aDouble * hDouble / 2));
        Continue();
    }

    static void TrapezoidArea()
    {
        Console.Clear();

        DrawLine("Area of Rextangle");


        bool result;
        int a,b, h;

        do
        {

            Console.WriteLine("Please enter lenght of shortside as cm: ");
            string aStr = Console.ReadLine();
            result = int.TryParse(aStr, out a);

        }
        while (result == false);

        do
        {

            Console.WriteLine("Please enter lenght of longside as cm: ");
            string bStr = Console.ReadLine();
            result = int.TryParse(bStr, out b);

        }
        while (result == false);


        do
        {
            Console.WriteLine("Please enter lenght of height as cm: ");

            string hStr = Console.ReadLine();
            result = int.TryParse(hStr, out h);

        }
        while (result == false);



        double aDouble = Convert.ToDouble(a);
        double bDouble = Convert.ToDouble(b);   
        double hDouble = Convert.ToDouble(h);


        Console.WriteLine();
        Console.WriteLine("Result: " + ((a + b) / 2d) * h);
        Continue();
    }

    static void SwitchCaseOpr(int selection)
    {
        switch (selection)
        {
            case 1:
                SquareArea();

                break;

            case 2:
                RectangleArea();

                break;


            case 3:
                TriangleArea();

                break;

            case 4:
                TrapezoidArea();

                break;

            default:
                Console.WriteLine("Please select number from the list");
                break;

        }
    }

   

}

