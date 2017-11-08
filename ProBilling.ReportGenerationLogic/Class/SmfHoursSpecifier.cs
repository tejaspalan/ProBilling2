using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class SmfHoursSpecifier:ICompanyMeetingHours
	{
		public float GetMeetingDuration()
		{
			float smfHours = 0.0f;

			if (HasMeetingAttended)
				smfHours = 1.0f;

			return smfHours;
		}

		public bool HasMeetingAttended { get; set; }
	}
}
