using System;
using System.Collections.Generic;
using Moq;
using Xunit;
using ProBilling.ReportGenerationLogic;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class MeetingHoursCalculatorTests
	{
		[Fact]
		public void ScrumMaster_GetTotalCompanyHoursPerDaySuccessfully()
		{
			var obj = new MeetingHoursCalculator();
			List<ICompanyMeetingHours> companyMeetings = new List<ICompanyMeetingHours>
			{
				new SosHoursSpecifier{HasMeetingAttended = true},
				new WowHoursSpecifier{HasMeetingAttended = true}
			};

			float result = obj.GetTotalCompanyHoursPerDay(companyMeetings);
			Assert.Equal(1.75, result);
		}
	}

}
