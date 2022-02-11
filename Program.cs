using System;

namespace numberone
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Silas";
            string favMovie = "The Matrix";
            Console.WriteLine($"hey {firstName.ToLower()}! i finally watched {favMovie.ToLower()} last night. i thought it was okay.");
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE"));
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);

            string quote = "I do not control the speed at which lobsters die.";
            Console.WriteLine(quote);
            quote = quote.ToLower();
            quote = quote.Replace("a", "");
            quote = quote.Replace("e", "");
            quote = quote.Replace("i", "");
            quote = quote.Replace("o", "");
            quote = quote.Replace("u", "");
            Console.WriteLine(quote);

            Console.Write("   ___     ___      ");
            Console.WriteLine("  _    ");
            Console.Write("  (o o)   (o o)     ");
            Console.WriteLine(">(.)__ ");
            Console.Write(" (  V  ) (  V  )    ");
            Console.WriteLine(" (___/ ");
            Console.Write("/--m-m- /--m-m-     ");
            



        }
    }
}
