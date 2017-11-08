using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	internal class WorkingHoursResult : IPerDayAttandanceInputWrapper
	{
		public string AttandanceStatus { get; set; }
	}
}