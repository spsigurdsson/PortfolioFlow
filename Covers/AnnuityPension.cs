namespace PortfolioFlow.Covers
{
    public class AnnuityPension : AbstractProduct 
    {
        public AnnuityPension(int id, SequenceYears<Money> max) : base(id,max)
        {
        }
    }

}