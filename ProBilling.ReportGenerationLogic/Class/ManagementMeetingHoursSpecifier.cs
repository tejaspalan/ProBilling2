using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class ManagementMeetingHoursSpecifier:ICompanyMeetingHours
	{
		public float GetMeetingDuration()
		{
			float managementMeetingHours = 0.0f;

			if (HasMeetingAttended)
				managementMeetingHours = 1.0f;

			return managementMeetingHours;
		}

		public bool HasMeetingAttended { get; set; }
	}
}