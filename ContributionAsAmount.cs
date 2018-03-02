using PortfolioFlow.Interfaces;

namespace PortfolioFlow
{
    public class ContributionAsAmount: IContribution
    {
        private readonly IYearSequence<Money> _contribution;

        // TODO: Input should be TimeSeries.
        public ContributionAsAmount(IYearSequence<Money> contirbution)
        {
            _contribution = contirbution;
        }

        public IYearSequence<Money> CalculateContribution(IYearSequence<Money> salaryPrYear)
        {
            return _contribution;
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