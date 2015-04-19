
using System;
using System.IO;
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

            var fullContactApi = new MyFullContactApi(apiKey);
            var inputLoop = new InputLoop(fullContactApi);
            inputLoop.Run();

            Environment.Exit(0);
        }
    }
}
