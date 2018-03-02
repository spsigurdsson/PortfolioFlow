using System;
using System.Collections.Generic;

namespace PortfolioFlow.Interfaces
{
    public interface IYearSequence<T> 
    {
         T this[int year]{get;set;}
         int Min {get;}
         int Max {get;}
         IEnumerable<int> AllYears{ get;}
         IYearSequence<T> Copy();
    }
}