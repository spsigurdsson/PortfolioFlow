using System.Linq;

namespace PortfolioFlow.YearSequence
{
    public class YearPercentSequence : YearSequence<Percent>{
        
        public override string ToString()
        {
            return _dictionary.OrderBy(x=>x.Key).Aggregate("",(s,n) =>s + $"[{n.Key}, {n.Value.ToString()}" +"\n");
        }
    }


}