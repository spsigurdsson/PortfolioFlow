using System;
using System.Linq;
using PortfolioFlow.Interfaces;
using PortfolioFlow.YearSequence;

namespace PortfolioFlow
{
    public class ContributionAsPercent : IContribution
    {

        // TODO: Input should be TimeSeries.
        public ContributionAsPercent(IYearSequence<Percent> percentOfSalary)
        {
            PercentOfSalary = percentOfSalary;
        }

        public IYearSequence<Percent> PercentOfSalary { get; }

        public IYearSequence<Money> CalculateContribution(IYearSequence<Money> salaryPrYear)
        {
            var min = Math.Min(salaryPrYear.Min,PercentOfSalary.Min);
            var max = Math.Max(salaryPrYear.Max,PercentOfSalary.Max);
            var r = new YearSequence<Money>();
            var zero = new Percent(0m);
            foreach(var y in Enumerable.Range(min, max - min + 1))
            {
                r[y] = salaryPrYear[y] * (PercentOfSalary[y] ?? zero);
            }

            return r;
        }
    }

    // Contribution fixed amount
    // Contribution as percent of salary
    // Contribution as percent of current limit cap
    // Contribution as rest of whole
    // Contribution as rest inside current limit

    // Tie breakers - Order
    // Fixed amount or percent, respect or truncate.

    // Get all covers. 
    // Order by tax codes, contribution rule, id.
    // Pour in contribution.
    // See how far we get. I.e. to which cover.

}