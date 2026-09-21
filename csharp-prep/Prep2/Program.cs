
class Program
{
    static void Main(string[] args)
    {
        string gradeStr;
        char symbol = ' ';

        Console.Write("What is your grade? ");
        gradeStr = Console.ReadLine();

        int grade = int.Parse(gradeStr);

        //finds the +/-
        if ((grade % 10) > 7){
            symbol = '+';
        }
        else if ((grade % 10) < 3){
            symbol = '-';
        }

        //finds the correct grade and writes it
        if (grade >= 100){
            Console.WriteLine($"You have an A+");
        }
        else if (grade >= 90){
            Console.WriteLine($"You have an A{symbol}");
        }
        else if (grade >= 80){
            Console.WriteLine($"You have an B{symbol}");     
        }
        else if (grade >= 70){
            Console.WriteLine($"You have an C{symbol}");
        }
        else if (grade >= 60){
            Console.WriteLine($"You have an D{symbol}");
        }else{
            Console.WriteLine("You have an F");
        }
    }
}