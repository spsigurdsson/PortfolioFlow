using System.Collections.Generic;

namespace PortfolioFlow.Interfaces {
    public interface IProduct {
        int Id { get; }
        SequenceYears<Money> Max { get; }
        SequenceYears<Money> Takes {get;}
    }
}