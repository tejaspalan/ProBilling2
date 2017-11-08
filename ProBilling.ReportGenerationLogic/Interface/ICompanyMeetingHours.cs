namespace ProBilling.ReportGenerationLogic.Interface
{
	public interface ICompanyMeetingHours
	{
		float GetMeetingDuration();

		bool HasMeetingAttended { get; set; }
	}
}