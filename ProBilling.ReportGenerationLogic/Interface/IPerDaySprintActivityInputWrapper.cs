using System;

namespace ProBilling.ReportGenerationLogic.Interface
{
	public interface IPerDaySprintActivityInputWrapper
	{
		string UserId { get; set; }

		int SprintId { get; set; }

		int TeamId { get; set; }

		DateTime Date { get; set; }
	}
}