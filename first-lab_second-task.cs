using System;

namespace first_lab
{
    class Program
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("Enter the number:");
            string Number = Console.ReadLine();
            string NewNumber = "";

            for (int NumberIndex = 0; NumberIndex < Number.Length; ++NumberIndex)
            {
                if (NumberIndex == 1)
                {
                    NumberIndex += 1;
                }
                NewNumber += Number[NumberIndex];
            }
            
            NewNumber += Number[1];
            Console.WriteLine($"New number: {NewNumber}");
            Console.ReadKey();
        }
    }
}
