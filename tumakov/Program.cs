using System;
namespace Tumakov
{
    class Laba
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        static void Task1()
        {
            Console.WriteLine("7.1");
            Bank account1 = new Bank();
            account1.Balance = 5551111;
            account1.AccountNumber = 134567890;
            account1.AccountType = BankAccountType.current;
            account1.Print();
        }
        static void Task2()
        {
            Console.WriteLine("7.2");
            Bank account2 = new Bank();
            account2.Balance = 1000;
            account2.AccountType = BankAccountType.savings;
            account2.Print();
        }
        static void Task3()
        {
            try
            {
                Console.WriteLine("7.3");
                Bank account3 = new Bank();
                Console.WriteLine("Введите баланс:");
                account3.Balance = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Сколько снять?");
                account3.Withdraw(decimal.Parse(Console.ReadLine()));
                Console.WriteLine("Сколько положить?");
                account3.Deposit(decimal.Parse(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        static void Task4()
        {
            try {
                Console.WriteLine("dz7.1");
                Building building = new Building(100, 30, 150, 5);
                building.Print();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
}