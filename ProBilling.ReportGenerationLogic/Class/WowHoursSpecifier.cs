using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class WowHoursSpecifier : ICompanyMeetingHours
	{
		public float GetMeetingDuration()
		{
			float wowHours = 0.0f;

			if (HasMeetingAttended)
				wowHours = 1.5f;

			return wowHours;
		}

		public bool HasMeetingAttended { get; set; }
	}
}
