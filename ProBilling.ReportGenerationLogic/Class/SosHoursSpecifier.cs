using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class SosHoursSpecifier: ICompanyMeetingHours
	{
		public float GetMeetingDuration()
		{
			float sosHours = 0.0f;

			if (HasMeetingAttended)
				sosHours = 0.25f;

			return sosHours;
		}

		public bool HasMeetingAttended { get; set; }
	}
}
