
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Circle myCircle = new Circle
        {
            _radius = 10
        };

        Console.WriteLine(myCircle.GetArea());
        
    }
}