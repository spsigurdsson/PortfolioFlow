<Query Kind="Program">
  <Reference Relative="..\bin\Debug\netstandard2.0\PortfolioFlow.dll">C:\Projects\PortfolioFlow\bin\Debug\netstandard2.0\PortfolioFlow.dll</Reference>
  <Namespace>PortfolioFlow</Namespace>
  <Namespace>PortfolioFlow.Covers</Namespace>
  <Namespace>PortfolioFlow.Interfaces</Namespace>
</Query>

void Main()
{
	var from = 2018;
	var to = 2060;
	
	
	var salary = new SequenceYears<Money>()
		.Fill(from,to,new Money(500000));
		
	var prcContribution = new ContributionAsPercent(new SequenceYears<Percent>()
		.Fill(2018,2055, new Percent(0m))
		.Fill(2018,2035, new Percent(0.08m))
		.Fill(2036,2055, new Percent(0.10m)));
		
	var contribution = prcContribution.CalculateContribution(salary);

	contribution.ToString().Dump();


	//salary[2018] = 1000000.AsMoney();
	
	//salary2.ToString().Dump();
}

// Define other methods and classes here
