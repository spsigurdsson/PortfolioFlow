namespace PortfolioFlow.Interfaces
{
    public interface IContribution
    {
        IYearSequence<Money> CalculateContribution(IYearSequence<Money> salaryPrYear);
    }
}