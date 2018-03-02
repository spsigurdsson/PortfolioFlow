using System;
using System.Collections.Generic;
using System.Linq;
using PortfolioFlow.Interfaces;

namespace PortfolioFlow
{

    public class SequenceYears<T> : ISequenceYears<T>
    {
        private readonly IDictionary<int, T> _dictionary;

        public SequenceYears(){
            _dictionary = new Dictionary<int,T>();
        }

        private SequenceYears(IDictionary<int, T> dictionary){
            _dictionary = new Dictionary<int,T>(dictionary); // Clone.
        }

        public int Max {get; private set;} = int.MinValue;

        public int Min {get; private set;} = int.MaxValue;


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
                    _dictionary.Add(year,value);
                    Max = Math.Max(year,Max);
                    Min = Math.Min(year,Min);
                }
            }
        }

        public IEnumerable<int> AllYears => _dictionary.Keys;

        public SequenceYears<T> Copy()
        {
            return new SequenceYears<T>(_dictionary);
        }

        public override string ToString()
        {
            return _dictionary.OrderBy(x=>x.Key).Aggregate("",(s,n) =>s + $"[{n.Key}, {n.Value.ToString()}]" +"\n");
        }

    }


}