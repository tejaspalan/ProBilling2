using ProBilling.ReportGenerationLogic;
using System;
using Moq;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;
using Xunit;

namespace ProBillingV1._1
{
	public class BillingAndKpiHoursSpecifyingTests
	{
		[Fact]
		public void ScrumMaster_BillingAndKpiAttendedSuccessfully()
		{
			var obj = new BillingAndKpiHoursSpecifier{HasMeetingAttended = true};
			float result = obj.GetMeetingDuration();
			Assert.Equal(1.5, result);
		}

		[Fact]
		public void ScrumMaster_BillingAndKpiNotAttendedSuccessfully()
		{
			var obj = new BillingAndKpiHoursSpecifier { HasMeetingAttended = false };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0, result);
		}
	}

}
