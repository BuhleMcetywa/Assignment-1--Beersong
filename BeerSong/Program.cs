using System.ComponentModel.Design;

namespace BeerSong
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bottles = 99;


            while (bottles > 2)
            {


                Console.WriteLine($"{bottles} bottles of beer on the wall,");
                Console.WriteLine($"{bottles} bottles of beer,");
                Console.WriteLine("Take one down, pass it around,");

                bottles--;
            }


            Console.WriteLine($"{bottles} bottles of beer on the wall,");
            Console.WriteLine($"{bottles} bottles of beer,");
            Console.WriteLine("Take one down, pass it around,");

            bottles--;


            Console.WriteLine($"{bottles} bottle of beer on the wall,");
            Console.WriteLine($"{bottles} bottle of beer,");

            bottles--;

        }
    }
}
        
    

