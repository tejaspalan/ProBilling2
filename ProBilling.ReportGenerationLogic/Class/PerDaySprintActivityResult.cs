using System;
using System.Collections.Generic;
using System.Text;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class PerDaySprintActivityResult : IPerDaySprintActivityInputWrapper
	{
		public string UserId { get; set; }

		public int SprintId { get; set; }

		public int TeamId { get; set; }

		public DateTime Date { get; set; }
	}
}
