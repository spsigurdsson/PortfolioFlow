namespace PortfolioFlow
{
    public struct Money {
        public Money (decimal amount = 0m) {
            Amount = amount;
        }

        public decimal Amount { get; }

        public static Money operator +(Money l, Money r){
           return new Money(l.Amount + r.Amount);
        }

        public static Money operator -(Money l, Money r){
           return new Money(l.Amount - r.Amount);
        }

        public static Money operator *(Money l, Percent r){
           return new Money(l.Amount * (r.AsFraction));
        }

        public static Money operator *(Percent l, Money r){
           return r*l;
        }

        public static Money operator /(Money l, Percent r){
           return new Money(l.Amount / (r.AsFraction));
        }

        public override string ToString()
        {
            return Amount.ToString("n");
        }
    }

    public static class MoneyAndPercentExtensions
    {
        public static Money AsMoney(this int money){
            return new Money(money);
        }

    }

    // Contribution fixed amount
    // Contribution as percent of salary
    // Contribution as percent of current limit cap
    // Contribution as rest of whole
    // Contribution as rest inside current limit

    // Tie breakers - Order
    // Fixed amount or percent, respect or truncate.

    // Get all covers. 
    // Order by tax codes, contribution rule, id.
    // Pour in contribution.
    // See how far we get. I.e. to which cover.

}