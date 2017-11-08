using System;
using Moq;
using Xunit;
using ProBilling.ReportGenerationLogic;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class BsdHoursSpecifyingTests
	{
		[Fact]
		public void ScrumMaster_BsdAttendedSuccessfully()
		{
			var obj = new BsdHoursSpecifier{HasMeetingAttended = true};
			float result = obj.GetMeetingDuration();
			Assert.Equal(1.5, result);
		}

		[Fact]
		public void ScrumMaster_BsdNotAttendedSuccessfully()
		{
			var obj = new BsdHoursSpecifier { HasMeetingAttended = false };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0, result);
		}
	}

}
