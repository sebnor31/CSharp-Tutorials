using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = superSecretFormula("Sebnor");
            Console.WriteLine(myValue);
            Console.ReadLine();

        }

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}!", name);
        }

    }
}
