using System;
using Xunit;
using ProBilling.ReportGenerationLogic;
using ProBilling.ReportGenerationLogic.Class;

namespace ProBillingV1._1
{
	public class AvailableHoursCalculatorTests
	{
		[Fact]
		public void ScrumMaster_CalculateAvailableHoursSuccessfully()
		{
			var obj = new AvailableHoursCalculator();
			float result = obj.CalculateAvailableHours(8.5f, 4.3f);
			Assert.Equal(4.2f, result);
		}
	}

}
