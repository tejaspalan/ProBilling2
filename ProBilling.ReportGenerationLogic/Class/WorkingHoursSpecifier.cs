using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class WorkingHoursSpecifier
	{
		private readonly IPerDayAttandanceInputWrapper _perDayAttandanceInputWrapper;

		public WorkingHoursSpecifier(IPerDayAttandanceInputWrapper perDayAttandanceInputWrapper)
		{
			_perDayAttandanceInputWrapper = perDayAttandanceInputWrapper;
		}

		public float GetWorkingHours()
		{
			float workingHours = 0.00f;

			if (_perDayAttandanceInputWrapper.AttandanceStatus.Equals("FullDay"))
				workingHours = 8.50f;

			else if (_perDayAttandanceInputWrapper.AttandanceStatus.Equals("HalfDay"))
				workingHours = 4.25f;

			return workingHours;
		}
	}
}
