using System;
using Moq;
using ProBilling.ReportGenerationLogic;
using Xunit;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class ManagementMeetingHoursSpecifyingTests
	{
		[Fact]
		public void ScrumMaster_ManagementMeetingAttendedSuccessfully()
		{
			var obj = new ManagementMeetingHoursSpecifier { HasMeetingAttended = true };
			float result = obj.GetMeetingDuration();
			Assert.Equal(1, result);
		}

		[Fact]
		public void ScrumMaster_ManagementMeetingNotAttendedSuccessfully()
		{
			var obj = new ManagementMeetingHoursSpecifier { HasMeetingAttended = false };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0, result);
		}
	}

}
