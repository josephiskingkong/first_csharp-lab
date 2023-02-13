using System;

namespace Calculator
{
  class firstlab
  {
    static void Main(string[] argv)
    {
      int A; int N;

      Console.WriteLine("Enter the number: ");
      A = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter the number degree: ");
      N = Convert.ToInt32(Console.ReadLine());

      for(int MultiplyCounter=1; MultiplyCounter<N; ++MultiplyCounter){
        A *= A; // A = A * A
      }

      Console.WriteLine($"{A} in {N} degree = {A}");
      Console.ReadKey();
    }
  }
}
