using System.Collections.Generic;
using PortfolioFlow.YearSequence;

namespace PortfolioFlow.Covers
{
    public class SumPension : AbstractProduct
    {
        public SumPension(int id, YearSequence<Money> max) : base(id, max)
        {
        }
    }

}