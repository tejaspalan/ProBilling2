using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class BillingAndKpiHoursSpecifier : ICompanyMeetingHours
	{
		public float GetMeetingDuration()
		{
			float billingHours = 0.0f;

			if (HasMeetingAttended)
				billingHours = 1.5f;

			return billingHours;
		}

		public bool HasMeetingAttended { get; set; }
	}
}
