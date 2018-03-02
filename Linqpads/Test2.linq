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
	
	var salary = new YearMoneySequence()
		.Fill(from,to,500000.AsMoney());
		
	var percent = new ContributionAsPercent(new YearPercentSequence()
		.Fill(from,to,new Percent(0.1m)));
		
	var contribution = percent.CalculateContribution(salary);
	
	
	contribution.ToString().Dump();
	
	




	//salary[2018] = 1000000.AsMoney();
	
	//salary2.ToString().Dump();
}

// Define other methods and classes here
