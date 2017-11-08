using System;
using Moq;
using Xunit;
using ProBilling.ReportGenerationLogic;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class WowHoursSpecifyingTests
	{
		[Fact]
		public void ScrumMaster_WoWAttendedSuccessfully()
		{
			var obj = new WowHoursSpecifier { HasMeetingAttended = true };
			float result = obj.GetMeetingDuration();
			Assert.Equal(1.5, result);
		}

		[Fact]
		public void ScrumMaster_WoWNotAttendedSuccessfully()
		{
			var obj = new WowHoursSpecifier { HasMeetingAttended = false };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0, result);
		}
	}

}
