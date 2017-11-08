using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class IgrowHoursSpecifier:ICompanyMeetingHours
	{
		public float GetMeetingDuration()
		{
			float iGrowHours = 0.0f;

			if (HasMeetingAttended)
				iGrowHours = 1.5f;

			return iGrowHours;
		}

		public bool HasMeetingAttended { get; set; }
	}
}