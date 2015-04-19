
using System;
using System.IO;
using System.Net.Mime;
using FullContactApi;
using System.Reflection;

namespace QE_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            var apiKey = String.Empty;
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                using (var textStreamReader = new StreamReader(assembly.GetManifestResourceStream("QE_Assignment2.FullContactKey.txt")))
                {
                    apiKey = textStreamReader.ReadLine();
                }
            }
            catch 
            {
                Console.WriteLine("Error accessing resources!");
                Environment.Exit(-1);
            }

            var person = new FullContactPerson
            {
                ApiKey = apiKey
            };

            Console.WriteLine(person);
        }
    }
}
