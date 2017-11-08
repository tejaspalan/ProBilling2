using System;
using Moq;
using Xunit;
using ProBilling.ReportGenerationLogic;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class TechTalkHoursSpecifyingTests
	{
		[Fact]
		public void ScrumMaster_TechTalkAttendedSuccessfully()
		{
			var obj = new TechTalkHoursSpecifier { HasMeetingAttended = true };
			float result = obj.GetMeetingDuration();
			Assert.Equal(1, result);
		}

		[Fact]
		public void ScrumMaster_TechTalkNotAttendedSuccessfully()
		{
			var obj = new TechTalkHoursSpecifier { HasMeetingAttended = false };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0, result);
		}
	}

}
