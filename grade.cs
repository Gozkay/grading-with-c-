using System;
class Grade
{
    static void Main()
    {
        Console.WriteLine("please enter score");
        int Grade = Convert.ToInt32(Console.ReadLine());
        int a = 75;
        int b = 65;
        int c = 55;
        int d = 45;
        if (Grade < d)
        {
            Console.WriteLine("your grade is F");
        }
        else if (Grade < c)
        {
            Console.WriteLine("your grade is D");

        }
        else if (Grade < b)
        {
            Console.WriteLine("your grade is C");
        }
        else if (Grade < a)
        {
            Console.WriteLine("your grade is B");

        }
        else if (Grade > a)
        {
            Console.WriteLine("your grade is A");

        }





    }
}
