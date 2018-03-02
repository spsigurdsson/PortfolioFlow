using System.Collections.Generic;

namespace PortfolioFlow.Interfaces {
    public interface IProduct {
        int Id { get; }
        IYearSequence<Money> Max { get; }
        IYearSequence<Money> Takes {get;}
    }
}