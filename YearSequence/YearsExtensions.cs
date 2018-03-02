using System;
using System.Linq;
using PortfolioFlow.Interfaces;

namespace PortfolioFlow.YearSequence
{
    public static class YearsExtensions
    {

        public static YearSequence<T> NewWithOneValueForAllYears<T>(this YearSequence<T> replicateFrom, T value){
            
            var newOne = new YearSequence<T>();

            foreach(var y in replicateFrom.AllYears)
            {
                newOne[y] = value;
            }

            return newOne;
        }

        public static IYearSequence<T> Fill<T>(this IYearSequence<T> years,int from, int to, T value)
        {
            var newYears = years.Copy();
            foreach(var y in Enumerable.Range(from, to - from + 1))
            {
                newYears[y] = value;
            }
            return newYears;
        }

        public static IYearSequence<T> Fill<T>(this IYearSequence<T> years,int from, int to, Func<T,T> fun)
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