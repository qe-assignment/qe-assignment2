using System;
using FullContactApi;

namespace QE_Assignment2
{
    public class InputLoop
    {
        private readonly MyFullContactApi _fullContactApi;

        public InputLoop(MyFullContactApi fullContactApi)
        {
            _fullContactApi = fullContactApi;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Input the email address of the person to lookup: ");
                Console.Write(">> ");
                var input = Console.ReadLine();
                if (input == "exit")
                    return;

                Display(input);
            }
        }

        private async void Display(string input)
        {
            var person = await _fullContactApi.LookupPersonByEmailAsync(input);
            Console.WriteLine(person.ToString());
        }
    }
}
