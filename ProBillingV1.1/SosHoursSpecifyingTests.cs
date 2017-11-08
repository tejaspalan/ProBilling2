using System;
using Moq;
using Xunit;
using ProBilling.ReportGenerationLogic;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class SosHoursSpecifyingTests
	{

		[Fact]
		public void ScrumMaster_ScrumOfScrumAttendedSuccessfully()
		{
			var obj = new SosHoursSpecifier { HasMeetingAttended = true };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0.25, result);
		}

		[Fact]
		public void ScrumMaster_ScrumOfScrumNotAttendedSuccessfully()
		{
			var obj = new SosHoursSpecifier { HasMeetingAttended = false };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0, result);
		}
	}

}
