using System;
enum AccountType
{
    Current,
    Savings
}
class BankAccount
{
    private string accountNumber;
    private decimal balance;
    private AccountType accountType;
    public void SetAccountNumber(string number) => accountNumber = number;
    public void SetBalance(decimal value) => balance = value;
    public void SetAccountType(AccountType type) => accountType = type;
    public string GetAccountNumber() => accountNumber;
    public decimal GetBalance() => balance;
    public AccountType GetAccountType() => accountType;
    public void Print()
    {
        Console.WriteLine($"Номер счёта: {accountNumber}");
        Console.WriteLine($"Баланс: {balance}");
        Console.WriteLine($"Тип счёта: {accountType}");
    }
}
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.SetAccountNumber("40817810099910004312");
        account.SetBalance(15000.50m);
        account.SetAccountType(AccountType.Savings);
        account.Print();
    }
}