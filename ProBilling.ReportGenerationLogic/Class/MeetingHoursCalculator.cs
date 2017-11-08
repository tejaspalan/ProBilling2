using System.Collections.Generic;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class MeetingHoursCalculator
	{
		public float GetTotalCompanyHoursPerDay(IEnumerable<ICompanyMeetingHours> companyMeetingsHours)
		{
			float totalHours = 0.00f;
			foreach (ICompanyMeetingHours companyMeetingHour in companyMeetingsHours)
			{
				totalHours = totalHours + companyMeetingHour.GetMeetingDuration();
			}
			return totalHours;
		}
	}
}
