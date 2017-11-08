using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class TechTalkHoursSpecifier:ICompanyMeetingHours
	{
		public float GetMeetingDuration()
		{
			float techTalkHours = 0.0f;

			if (HasMeetingAttended)
				techTalkHours = 1.0f;

			return techTalkHours;
		}

		public bool HasMeetingAttended { get; set; }
	}
}