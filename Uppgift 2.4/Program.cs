using System;

namespace Uppgift2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket tjänar person 1 i ditt företag?");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket tjänar person 2 i ditt företag?");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket tjänar person 3 i ditt företag?");
            float z = float.Parse(Console.ReadLine());
            float medel = (x + y + z) / 2;
            Console.WriteLine("Medellönen för personalen är " + medel);
        }
    }
}