using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class BsdHoursSpecifier : ICompanyMeetingHours
	{
		public float GetMeetingDuration()
		{
			float bsdHours = 0.0f;

			if (HasMeetingAttended)
				bsdHours = 1.5f;

			return bsdHours;
		}

		public bool HasMeetingAttended { get; set; }
	}
}