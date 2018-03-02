using PortfolioFlow.YearSequence;

namespace PortfolioFlow.Covers
{
    public class AnnuityPension : AbstractProduct 
    {
        public AnnuityPension(int id, YearSequence<Money> max) : base(id,max)
        {
        }
    }

}