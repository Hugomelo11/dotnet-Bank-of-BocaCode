
public class BankAccount {

    public string AccountNumber {get; set;} 

    public decimal Balance {get; set;} = 0;


    public BankAccount() {
        AccountNumber = "";
        Balance = 100;
    }

    public BankAccount(decimal newBalance) {
        AccountNumber = "";
        Balance = newBalance;
    }

    public void MakeDeposit(decimal amount) {
        if (amount <= 0) {
            throw new Exception("Doh!");
        }
        Balance += amount;
    }
    
    public decimal MakeDepositGetBalance(decimal amount) {
        MakeDeposit(amount);
        return Balance;
    }



}