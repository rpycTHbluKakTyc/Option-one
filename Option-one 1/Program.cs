using System;

namespace Option_one_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputData = Console.ReadLine();

            for (int i = InputData.Length - 1; i >= 0; i--)

            {
                Console.Write(InputData[i]);
            }
        }
    }
}
