
public class SavingAccount : BankAccount {

    public SavingAccount() : base()         // base class taking things from the constructor
    {
        Balance = 200;
    }

    public SavingAccount(decimal amount) : base(amount) {
        
    }

}