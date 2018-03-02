using System;
using System.Linq;

namespace PortfolioFlow
{
    public static class YearsExtensions
    {

        public static SequenceYears<T> NewWithOneValueForAllYears<T>(this SequenceYears<T> replicateFrom, T value){
            
            var newOne = new SequenceYears<T>();

            foreach(var y in replicateFrom.AllYears)
            {
                newOne[y] = value;
            }

            return newOne;
        }

        public static SequenceYears<T> Fill<T>(this SequenceYears<T> years,int from, int to, T value)
        {
            var newYears = years.Copy();
            foreach(var y in Enumerable.Range(from, to - from + 1))
            {
                newYears[y] = value;
            }
            return newYears;
        }

        public static SequenceYears<T> Fill<T>(this SequenceYears<T> years,int from, int to, Func<T,T> fun)
        {
            var newYears = years.Copy();
            foreach(var y in Enumerable.Range(from, to - from + 1))
            {
                newYears[y] = fun(newYears[y]);
            }
            return newYears;
        }


    }


}