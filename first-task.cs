using System;

namespace Calculator
{
  class firstlab
  {
    static void Main(string[] argv)
    {
      int A; int N; int OldN; int OldA;

      Console.WriteLine("Enter the number: ");
      A = Convert.ToInt32(Console.ReadLine());
      OldA = A;

      Console.WriteLine("Enter the number degree: ");
      N = Convert.ToInt32(Console.ReadLine());

      OldN = N;

      while (N > 1)
      {
        A = A * OldA;
        N = N - 1;
      }

      Console.WriteLine($"{OldA} in {OldN} degree = {A}");
      Console.ReadKey();
    }
  }
}
