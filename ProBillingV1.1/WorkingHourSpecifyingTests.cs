using System;
using Moq;
using Xunit;
using ProBilling.ReportGenerationLogic;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class WorkingHourSpecifyingTests
	{
		
		[Fact]
		public void ScrumMaster_WorkingHoursSetForFullDayAttendance_Successfully()
		{
			var perDayAttandanceInputWrapper = new Mock<IPerDayAttandanceInputWrapper>();
			perDayAttandanceInputWrapper.Setup(item => item.AttandanceStatus).Returns("FullDay");

			var obj = new WorkingHoursSpecifier(perDayAttandanceInputWrapper.Object);
			float result = obj.GetWorkingHours();
			Assert.Equal(8.50, result);
		}

		[Fact]
		public void ScrumMaster_WorkingHoursSetForHalfDayAttendance_Successfully()
		{
			var perDayAttandanceInputWrapper = new Mock<IPerDayAttandanceInputWrapper>();
			perDayAttandanceInputWrapper.Setup(item => item.AttandanceStatus).Returns("HalfDay");

			var obj = new WorkingHoursSpecifier(perDayAttandanceInputWrapper.Object);
			float result = obj.GetWorkingHours();
			Assert.Equal(4.25, result);
		}

		[Fact]
		public void ScrumMaster_WorkingHoursSetForNoAttendance_Successfully()
		{
			var perDayAttandanceInputWrapper = new Mock<IPerDayAttandanceInputWrapper>();
			perDayAttandanceInputWrapper.Setup(item => item.AttandanceStatus).Returns("Absent");

			var obj = new WorkingHoursSpecifier(perDayAttandanceInputWrapper.Object);
			float result = obj.GetWorkingHours();
			Assert.Equal(0, result);
		}
	}

}
