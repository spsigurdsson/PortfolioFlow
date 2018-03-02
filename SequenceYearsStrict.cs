using System;
using System.Collections.Generic;
using System.Linq;
using PortfolioFlow.Interfaces;

namespace PortfolioFlow
{

    public class SequenceYearsStrict<T> : ISequenceYears<T>
    {
        private readonly IDictionary<int, T> _dictionary;

        public SequenceYearsStrict(int from, int to, T value){

            _dictionary = new Dictionary<int,T>();
            Add(from,to,value);
        }

        private SequenceYearsStrict(IDictionary<int, T> dictionary){
            _dictionary = new Dictionary<int,T>(dictionary); // Clone.
        }

        public int Max {get; private set;} = int.MinValue;

        public int Min {get; private set;} = int.MaxValue;

        private void Add(int from, int to, T value)
        {
            foreach(var y in Enumerable.Range(from,to-from + 1))
            {
               _dictionary.Add(y,value);
            }
        }

        public T this[int year]{
            get
            {   
                T a;
                _dictionary.TryGetValue(year,out a);
                return a;
            }    
            set
            {
                if(_dictionary.ContainsKey(year))
                {
                    _dictionary[year] = value;    
                }
                else
                {
                    if(year > Max)
                    {
                        Add(Max+1,year,value);
                    }else if(year < Min){
                        Add(year,Min-1,value);
                    }else{
                        _dictionary.Add(year,value);
                    }
                    
                    Max = Math.Max(year,Max);
                    Min = Math.Min(year,Min);
                }
            }
        }

        public IEnumerable<int> AllYears => _dictionary.Keys;

        public ISequenceYears<T> Copy()
        {
            return new SequenceYearsStrict<T>(_dictionary);
        }

        public override string ToString()
        {
            return _dictionary.OrderBy(x=>x.Key).Aggregate("",(s,n) =>s + $"[{n.Key}, {n.Value.ToString()}]" +"\n");
        }

    }


}