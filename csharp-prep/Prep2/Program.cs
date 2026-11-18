using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you get in this course? ");
        string gradeFromUser = Console.ReadLine();

        int x = int.Parse(gradeFromUser);

        if (x >= 90) {
            Console.Write("You got an A in this course, congratulations. You passed!");
        
        }

        else if (x >= 80)
        {
            Console.Write("You got a B in this course. You passed!"); 
        }

        else if (x >= 70)
        {
            Console.Write("You got a C in this course. You passed!");
        }
        else if (x >= 60)
        {
            Console.Write("You got a D in this course. You passed!");
        }

        else
        {
            Console.Write("You've failed this course. Good Luck Next Time");
        }


    


    }
}