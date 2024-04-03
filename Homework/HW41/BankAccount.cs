namespace HW41;

class BankAccount : IEquatable<BankAccount>, IComparable<BankAccount>
{
    public decimal Money { get; set; }

    public BankAccount(int money)
    {
        Money = money;
    }

    public override string ToString()
    {
        return base.ToString() + $", Money = {Money}\n";
    }

    public bool Equals(BankAccount other)
    {
        return this.CompareTo(other) == 0;
    }

    public int CompareTo(BankAccount other)
    {
        return this.Money.CompareTo(other.Money);
    }
}