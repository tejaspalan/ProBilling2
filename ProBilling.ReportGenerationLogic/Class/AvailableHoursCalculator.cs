namespace ProBilling.ReportGenerationLogic.Class
{
	public class AvailableHoursCalculator
	{
		public float CalculateAvailableHours(float attendanceHours, float companyMeetingHours)
		{
			return attendanceHours - companyMeetingHours;
		}
	}
}
