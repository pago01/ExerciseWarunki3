using System.ComponentModel.Design;

namespace ExerciseWarunki3
{
    //Data structure declaration

    class Program
    {

        private static void Main(string[] args)
        {
            int a = 0;

            //a
            Console.WriteLine("Podaj liczbe");
            Int32.TryParse(Console.ReadLine(), out a);

            //Display data
            if (a > 0)
            {
                Console.WriteLine($"Liczba : {a} jest dodatnia");
            }
            else if (a < 0)
            {
                Console.WriteLine($"Liczba : {a} jest ujemna");
            }
            else
                Console.WriteLine($"Liczba : {a} jest zerem");
        }
    }
}
