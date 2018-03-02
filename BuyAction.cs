namespace PortfolioFlow
{
    public class BuyAction {

        public BuyAction (int id, TaxType type, Money amount) {
            Id = id;
            Type = type;
            Amount = amount;
        }

        public int Id { get; }
        public TaxType Type { get; }
        public Money Amount { get; }
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