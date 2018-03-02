using System;

namespace PortfolioFlow.Interfaces
{
    public interface ISequenceYears<T> 
    {
         T this[int year]{get;}
         int Min {get;}
         int Max {get;}
    }

    public interface ISequence<T, TK> where T : IComparable
    {
        TK this[T time]{get;}


    }
}