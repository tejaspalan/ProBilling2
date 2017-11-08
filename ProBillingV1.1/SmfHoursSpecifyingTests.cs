using System;
using Moq;
using Xunit;
using ProBilling.ReportGenerationLogic;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class SmfHoursSpecifyingTests
	{
		[Fact]
		public void ScrumMaster_SmfAttendedSuccessfully()
		{
			var obj = new SmfHoursSpecifier{HasMeetingAttended = true};
			float result = obj.GetMeetingDuration();
			Assert.Equal(1.0, result);
		}

		[Fact]
		public void ScrumMaster_SmfNotAttendedSuccessfully()
		{
			var obj = new SmfHoursSpecifier { HasMeetingAttended = false };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0, result);
		}
	}

}
