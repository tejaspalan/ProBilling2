using Xunit;
using ProBilling.ReportGenerationLogic.Class;

namespace ProBillingV1._1
{
	public class IgrowHoursSpecifyingTests
	{
		[Fact]
		public void ScrumMaster_IgrowAttendedSuccessfully()
		{
			var obj = new IgrowHoursSpecifier { HasMeetingAttended = true };
			float result = obj.GetMeetingDuration();
			Assert.Equal(1.5, result);
		}

		[Fact]
		public void ScrumMaster_IgrowNotAttendedSuccessfully()
		{
			var obj = new IgrowHoursSpecifier { HasMeetingAttended = false };
			float result = obj.GetMeetingDuration();
			Assert.Equal(0, result);
		}
	}

}
