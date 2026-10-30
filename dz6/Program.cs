using System;

enum AccountType { Current, Savings }

class BankAccount
{
    private static int lastNumber = 0;
    private int accountNumber;
    private decimal balance;
    private AccountType accountType;
    public BankAccount()
    {
        accountNumber = GenerateNumber();
    }
    private static int GenerateNumber()
    {
        lastNumber++;
        return lastNumber;
    }
    public int GetAccountNumber() => accountNumber;
    public void SetBalance(decimal value) => balance = value;
    public decimal GetBalance() => balance;
    public void SetAccountType(AccountType type) => accountType = type;
    public AccountType GetAccountType() => accountType;
    public void Print()
    {
        Console.WriteLine($"Номер счёта: {accountNumber}");
        Console.WriteLine($"Баланс: {balance}");
        Console.WriteLine($"Тип счёта: {accountType}");
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        BankAccount first = new BankAccount();
        first.SetBalance(15000.50m);
        first.SetAccountType(AccountType.Savings);
        BankAccount second = new BankAccount();
        second.SetBalance(3200m);
        second.SetAccountType(AccountType.Current);
        BankAccount third = new BankAccount();
        third.SetBalance(100m);
        third.SetAccountType(AccountType.Current);
        first.Print();
        second.Print();
        third.Print();
    }
}