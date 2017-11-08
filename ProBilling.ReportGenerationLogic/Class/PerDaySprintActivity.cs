using System;
using System.Collections.Generic;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBilling.ReportGenerationLogic.Class
{
	public class PerDaySprintActivity
	{
		private readonly IPerDaySprintActivityInputWrapper _perDaySprintActivityInputWrapper;
		private readonly IPerDaySprintActivitySave _perDaySprintActivitySave;
		private readonly MeetingStatus _meetingStatus;
		private IPerDaySprintActivityInputWrapper perDaySprintActivityInputWrapper;
		private MeetingStatus meetingStatus;

		public string UserId { get; set; }
		public int SprintId { get; set; }
		public int TeamId { get; set; }
		public DateTime Date { get; set; }
		public float CompanyMeetingHours { get; set; }
		public float AvailableHours { get; set; }

		public PerDaySprintActivity(IPerDaySprintActivityInputWrapper perDaySprintActivityInputWrapper,MeetingStatus meetingStatus,IPerDaySprintActivitySave perDaySprintActivitySave)
		{
			_perDaySprintActivityInputWrapper = perDaySprintActivityInputWrapper;
			_meetingStatus = meetingStatus;
			_perDaySprintActivitySave = perDaySprintActivitySave;
		}

		public PerDaySprintActivity(IPerDaySprintActivityInputWrapper perDaySprintActivityInputWrapper, MeetingStatus meetingStatus)
		{
			this.perDaySprintActivityInputWrapper = perDaySprintActivityInputWrapper;
			this.meetingStatus = meetingStatus;
		}

		public void Save()
		{
			UserId = _perDaySprintActivityInputWrapper.UserId;
			SprintId = _perDaySprintActivityInputWrapper.SprintId;
			TeamId = _perDaySprintActivityInputWrapper.TeamId;
			Date = _perDaySprintActivityInputWrapper.Date;
			CalculateMeetingAndAvailableHours();
			_perDaySprintActivitySave.Save(this);
		}

		public void CalculateMeetingAndAvailableHours()
		{
			var wowMeeting = new WowHoursSpecifier{HasMeetingAttended = _meetingStatus.IsWowAttended };
			var billingAndKpiHoursSpecifier = new BillingAndKpiHoursSpecifier{HasMeetingAttended = _meetingStatus.IsBillingAndKpiAttended };
			var bsdHoursSpecifier = new BsdHoursSpecifier{HasMeetingAttended = _meetingStatus.IsBsdAttended };
			var igrowHoursSpecifier = new IgrowHoursSpecifier {HasMeetingAttended = _meetingStatus.IsIgrowAttended };
			var managementMeetingHoursSpecifier = new ManagementMeetingHoursSpecifier { HasMeetingAttended = _meetingStatus.IsManagemenetMeetingAttended };
			var smfHoursSpecifier = new SmfHoursSpecifier { HasMeetingAttended = _meetingStatus.IsSmfAttended };
			var sosHoursSpecifier = new SosHoursSpecifier { HasMeetingAttended = _meetingStatus.IsSosAttended };
			var techTalkHoursSpecifier = new TechTalkHoursSpecifier { HasMeetingAttended = _meetingStatus.IsTechTalkAttended };

			var workingHoursResult = new WorkingHoursResult() { AttandanceStatus = _meetingStatus.AttendeenceStatus };
			var workingHoursSpecifier = new WorkingHoursSpecifier(workingHoursResult);


			List<ICompanyMeetingHours> companyMeetingHours = new List<ICompanyMeetingHours>
			{
				wowMeeting,
				billingAndKpiHoursSpecifier,
				bsdHoursSpecifier,
				igrowHoursSpecifier,
				managementMeetingHoursSpecifier,
				smfHoursSpecifier,
				sosHoursSpecifier,
				techTalkHoursSpecifier
			};

			MeetingHoursCalculator meetingHoursCalculator = new MeetingHoursCalculator();

			CompanyMeetingHours = meetingHoursCalculator.GetTotalCompanyHoursPerDay(companyMeetingHours);

			AvailableHoursCalculator availableHoursCalculator = new AvailableHoursCalculator();

			AvailableHours = availableHoursCalculator.CalculateAvailableHours(workingHoursSpecifier.GetWorkingHours(), CompanyMeetingHours);
		}
	}
}
