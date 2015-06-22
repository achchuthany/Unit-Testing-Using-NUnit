using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers\n");
            int number1;
            int number2;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            MathsHellper helper = new MathsHellper();

            int x = helper.Add(number1, number2);
            Console.WriteLine("\n The sum of " + number1 + " and " + number2 + " is " + x);

            int y = helper.Subtract(number1, number2);
            Console.WriteLine("\n The difference between " + number1 + " and " + number2 + " is " + y);

            Console.ReadKey();
        }  
    }

    public class MathsHellper
    {
        public MathsHellper() { }
        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }
        public int Subtract(int a, int b)
        {
            int x = a - b;
            return x;
        }
    }

    public class BankAccount
    {
        public BankAccount()
            : this(0)
        {
            
        }

        public BankAccount(double intialBalance)
        {
            Balance = intialBalance;
        }

        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
