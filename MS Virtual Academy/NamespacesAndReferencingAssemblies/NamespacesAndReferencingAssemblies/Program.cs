using System;
using System.IO;
using Tabor;

namespace NamespacesAndReferencingAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Bob myBob = new Bob();

            string url = myBob.Lookup("http://www.learnvisualstudio.net");

            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
