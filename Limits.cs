using System.Collections.Generic;
using PortfolioFlow.Interfaces;

namespace PortfolioFlow
{
    // Contribution store, where covers come to buy contribution.
    // 1. We look up limit for given category. How much is left. 0 we return.
    // 2. We look up how much income is left. 0 we return.
    // 3. We apply the rule of the product, i.e. how much should it take.
    // 4. We generate an BuyAction for the product (perhaps return a new product)
    // 5. Update income left and limits left.
    public class Limits {

        /// The income or total contribution to distribute.
        private readonly SequenceYears<Money> _income;
        /// The limits for each taxcode, left.
        private readonly IDictionary<TaxType, SequenceYears<Money>> _limitByTaxCode;
        /// A list of actions in covers and how much contribution.
        private readonly IList<BuyAction> Actions = new List<BuyAction> ();
        /// The covers come in here to buy.
        public void Buy (IProduct a) {
            //NB. Caller should have sent in orderly.

            // return.

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