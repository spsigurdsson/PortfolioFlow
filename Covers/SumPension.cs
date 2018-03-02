using System.Collections.Generic;

namespace PortfolioFlow.Covers
{
    public class SumPension : AbstractProduct
    {
        public SumPension(int id, SequenceYears<Money> max) : base(id, max)
        {
        }
    }

}