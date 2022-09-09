using Exceções.Entities;
using System;
using Exceções.Entities.Exceptions;
namespace Exceções
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Enter account data :");
                Console.Write("Number :");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Initial Balance :");
                double initialbalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit :");
                double witdrawlimit = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                Conta conta = new Conta(number, name, initialbalance, witdrawlimit);

                Console.Write("Enter amount for withdraw :");
                double amount = double.Parse(Console.ReadLine());
                conta.Withdraw(amount);

                Console.WriteLine(conta);

            }

            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
 

        }
    }
}
