using System;
using System.Threading.Tasks;
using System.Threading;

namespace pariedispari
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Thread thread = new Thread(StampaNumeri);
                thread.Start();
                StampaNumeri();
            }
            static void StampaNumeri()
            {
                for (int i = 1; i <= 100; i++)
                {
                    int n = i;
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"pari    {n}");
                    }
                    else
                    {
                        Console.WriteLine($"dispari {n}");
                    }
                }
            }
        }
    }
}
