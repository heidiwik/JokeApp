using System;
using System.Threading;
using System.Threading.Tasks;
using APIHelpers;


namespace HealthApp
{
    class Program
    {
        private static void PrintJoke(Joke joke)
        {
            Console.WriteLine(joke.joke);
        }


        private static async Task GetRandomJoke()
        {
            Console.WriteLine("  *** Hello from joke app *** \n");
            Console.Write("\nGive category: ");
            string input = Console.ReadLine();

            Joke joke = await JokeApi.GetRandomJoke(input);

            PrintJoke(joke);
        }


        static void Main(string[] args)
        {
            GetRandomJoke();
            Console.ReadKey(true);
        }
    }
}

