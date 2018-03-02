using System.Collections.Generic;
using PortfolioFlow.Interfaces;

namespace PortfolioFlow.Covers
{
    public abstract class AbstractProduct : IProduct {

        public AbstractProduct (int id, SequenceYears<Money> max) {
            Id = id;
            Max = max;
            Takes = max.NewWithOneValueForAllYears(new Money(0m));
        }

        public int Id { get; }
        public SequenceYears<Money> Max { get; }
        public SequenceYears<Money> Takes { get; }
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