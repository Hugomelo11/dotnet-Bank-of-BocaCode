// test bank program
Console.WriteLine("Welcome to Bank of Boca Code");

BankAccount account = new BankAccount();
account.AccountNumber = "123456";

account.MakeDeposit(100);

BankAccount account2 = new SavingAccount(500);
try {
decimal newBalance = account2.MakeDepositGetBalance(-1);
} catch(Exception ex) {
    Console.WriteLine($"we got an error when running MakeDepositGetBalance(-1) " + ex.Message);
}

Console.WriteLine($"The balance of your account is {account.Balance}");
Console.WriteLine($"The Account Number is {account.AccountNumber}");

Console.WriteLine($"The balance of your Savings is {account2.Balance}");

