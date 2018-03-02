using System;

namespace PortfolioFlow
{
    public class Percent
    {
        /// <summary>
        /// Name: asFraction
        /// Type/default: Number 
        /// Constraints: Mandatory
        /// Description: Specifies the percentage as a fraction. 1.5% = 0.015
        /// </summary>
        public decimal AsFraction { get; }

        /// <summary>
        /// Either construct using the fractional value og percent value. Entering both
        /// the input is validated to match: fractional value * 100 = percent value. ArgumentException is
        /// thrown if they do not match, and also if both are null
        /// </summary>
        /// <param name="asFraction"></param>
        /// <param name="asPercent"></param>
        public Percent(decimal? asFraction = null, decimal? asPercent = null)
        {
            if (asFraction == null && asPercent == null)
                throw new ArgumentException($"Both parameters cannot be null");

            if (asFraction != null && asPercent != null)
                if (!asFraction.Equals(asPercent / 100m))
                    throw new ArgumentException($"Parameters does not match ({asPercent} != {asFraction} * 100)");

            if (asFraction != null)
                AsFraction = (decimal)asFraction;

            if (asPercent != null)
                AsFraction = ((decimal)asPercent) / 100;
        }

        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            return $"{(AsFraction*100).ToString("N2")}%";
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