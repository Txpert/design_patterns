using System;
namespace Command
{
    public class WithdrawCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount;
        private double amount;
        bool transactionSucceeded;

        public WithdrawCommand(BankAccount bankAccount, double amount)
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
        }

        public void Execute()
        {
            transactionSucceeded = bankAccount.Withdraw(amount);
        }

        public void Undo()
        {
            if (transactionSucceeded)
            {
                bankAccount.Balance += amount;
                Console.WriteLine("The withdraw was made by mistake. New Balance: " + bankAccount.Balance);
            }
            else
            {
                Console.WriteLine("The undo funktion cannot be excuted");
            }
        }
    }
}

