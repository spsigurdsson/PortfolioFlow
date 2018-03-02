using System;
using System.Collections.Generic;

namespace PortfolioFlow.Interfaces
{
    public interface ISequenceYears<T> 
    {
         T this[int year]{get;set;}
         int Min {get;}
         int Max {get;}
         IEnumerable<int> AllYears{ get;}
         ISequenceYears<T> Copy();
    }

    public interface ISequence<T, TK> where T : IComparable
    {
        TK this[T time]{get;}


    }
}