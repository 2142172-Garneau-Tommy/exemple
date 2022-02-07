using System;

namespace carré_cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = 4; 
            
            int nombres = 0;

            Console.WriteLine("Entrez un nombre pour connaitre le carré de ce nombre");
            int.TryParse(Console.ReadLine(), out nombre);
            Console.WriteLine($"\nLe carré du nombre est {nombre  * nombre }",nombre );
            Console.WriteLine("Entrez un autre nombre pour connaitre son cube");
            int.TryParse(Console.ReadLine(), out nombres);
            Console.WriteLine($"\nLe cube du nombre est {nombres * nombres * nombres}",nombres);
           

            
            
        }
    }
}
