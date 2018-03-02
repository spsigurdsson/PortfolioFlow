namespace PortfolioFlow.Interfaces
{
    public interface IContribution
    {
        ISequenceYears<Money> CalculateContribution(ISequenceYears<Money> salaryPrYear);
    }
}