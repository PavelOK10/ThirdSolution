using System;
namespace MySecondConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 200;
            do
            {
                ++i;
                if (i % 17 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            while (i < 500);
        }
    }
}
