using System;
namespace Command
{
    public class DepositCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount; //reference the owner
        private double amount; //the deposit amount 

        public DepositCommand(BankAccount bankAccount, double amount) //constr
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
        }

        public void Execute()
        {
            bankAccount.Deposit(amount);
        }

        public void Undo()
        {
            bankAccount.Balance -= amount;
            Console.WriteLine("The deposit was made by mistake. New Balance: " + bankAccount.Balance);
        }
    }
}

