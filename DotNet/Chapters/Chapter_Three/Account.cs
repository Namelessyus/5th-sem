using System;

namespace ChapterThree
{
    class Account
    {
        public long AccountNumber { get; set; }
        public int Amount { get; set; }
    }

    class SavingAccount: Account
    {
        public void ShowAmount()
        {
            Console.WriteLine($"{AccountNumber} has {Amount} in the account");
        }
    }

    class CurrentAccount : SavingAccount
    {
        public new void ShowAmount()
        {
            Console.WriteLine($"{AccountNumber} has {Amount} in the current account");
        }
    }

    internal class HierarchicalInheritance
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount();
            sa.AccountNumber = 1234567890;
            sa.Amount = 5000;
            sa.ShowAmount();

            CurrentAccount ca = new CurrentAccount();
            ca.AccountNumber = 20100202028392;
            ca.Amount = 100000000;
            ca.ShowAmount();
        }
    }
}