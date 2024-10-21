using System;

public class Program
{


    public static void Main(string[] args)
    {
        Console.WriteLine("enter your score of this class");
        string Grade1 = Console.ReadLine();
        int GradeForClass = int.Parse(Grade1);
        if (GradeForClass >= 100)
        {
            Console.WriteLine("Wow thats amazing");
            Console.WriteLine("Letter grade: A+");
        }
        else if (GradeForClass >= 90)
        {
            Console.WriteLine("Pretty good");
            Console.WriteLine("Letter grade: A");


        }
        else if (GradeForClass >= 80)
        {
            Console.WriteLine("Not to bad");
            Console.WriteLine("Letter grade: B");
        }
        else if (GradeForClass >= 70)
        {
            Console.WriteLine("Can be better");
            Console.WriteLine("Letter Grade: C");

        }
        else if (GradeForClass >= 60 ){
            Console.WriteLine("Keep trying ");
            Console.WriteLine("Letter grade: D");
        }
        else{
            Console.WriteLine("You can do better");
            Console.WriteLine("letter Grade:E");
        }



    }
}