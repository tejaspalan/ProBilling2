using System;
using Moq;
using Xunit;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class PerDaySprintActivityTests
	{
		private readonly IPerDaySprintActivitySave _perDaySprintActivitySave;

		public PerDaySprintActivityTests()
		{
			_perDaySprintActivitySave = new Mock<IPerDaySprintActivitySave>().Object;
		}

		[Fact]
		public void PerDaySprintActivity_AssignUserId_ShouldAssignTheCorrectUserId()
		{
			var perDaySprintActivityInputWrapper = new Mock<IPerDaySprintActivityInputWrapper>();
			perDaySprintActivityInputWrapper.Setup(item => item.UserId).Returns("testString");

			var obj = new PerDaySprintActivity(perDaySprintActivityInputWrapper.Object,new MeetingStatus { AttendeenceStatus = "FullDay" }, _perDaySprintActivitySave);
			obj.Save();
			Assert.Equal("testString", obj.UserId);
		}

		[Fact]
		public void PerDaySprintActivity_AssignUserId_ShouldAssignTheCorrectSprintId()
		{
			var perDaySprintActivityInputWrapper = new Mock<IPerDaySprintActivityInputWrapper>();
			perDaySprintActivityInputWrapper.Setup(item => item.SprintId).Returns(1);

			var obj = new PerDaySprintActivity(perDaySprintActivityInputWrapper.Object, new MeetingStatus { AttendeenceStatus = "FullDay" }, _perDaySprintActivitySave);
			obj.Save();
			Assert.Equal(1, obj.SprintId);
		}

		[Fact]
		public void PerDaySprintActivity_AssignUserId_ShouldAssignTheCorrectTeamId()
		{
			var perDaySprintActivityInputWrapper = new Mock<IPerDaySprintActivityInputWrapper>();
			perDaySprintActivityInputWrapper.Setup(item => item.TeamId).Returns(1);

			var obj = new PerDaySprintActivity(perDaySprintActivityInputWrapper.Object, new MeetingStatus { AttendeenceStatus = "FullDay" }, _perDaySprintActivitySave);
			obj.Save();
			Assert.Equal(1, obj.TeamId);
		}

		[Fact]
		public void PerDaySprintActivity_AssignUserId_ShouldAssignTheCorrectDate()
		{
			var perDaySprintActivityInputWrapper = new Mock<IPerDaySprintActivityInputWrapper>();
			perDaySprintActivityInputWrapper.Setup(item => item.Date).Returns(DateTime.Now.Date);

			var obj = new PerDaySprintActivity(perDaySprintActivityInputWrapper.Object,new MeetingStatus{AttendeenceStatus = "FullDay"}, _perDaySprintActivitySave);
			obj.Save();
			Assert.Equal(DateTime.Now.Date, obj.Date);
		}

		[Fact]
		public void PerDaySprintActivity_Save_ShouldCalculateAndAssignTheCorrectCompanyMeetingHours()
		{
			MeetingStatus meetingStatus = new MeetingStatus
			{
				AttendeenceStatus = "FullDay",
				IsBillingAndKpiAttended = true,
				IsBsdAttended = true,
				IsIgrowAttended = true,
				IsManagemenetMeetingAttended = true,
				IsSmfAttended = true,
				IsSosAttended = true,
				IsTechTalkAttended = true,
				IsWowAttended = true
			};
			var perDaySprintActivityInputWrapper = new Mock<IPerDaySprintActivityInputWrapper>();

			var obj = new PerDaySprintActivity(perDaySprintActivityInputWrapper.Object, meetingStatus, _perDaySprintActivitySave);
			obj.Save();
			Assert.InRange(obj.CompanyMeetingHours,0.1,100);
		}

		[Fact]
		public void PerDaySprintActivity_Save_ShouldCalculateAndAssignTheCorrectAvailableHours()
		{
			MeetingStatus meetingStatus = new MeetingStatus
			{
				AttendeenceStatus = "FullDay",
				IsBillingAndKpiAttended = true,
				IsBsdAttended = true,
				IsIgrowAttended = true
			};
			var perDaySprintActivityInputWrapper = new Mock<IPerDaySprintActivityInputWrapper>();

			var obj = new PerDaySprintActivity(perDaySprintActivityInputWrapper.Object, meetingStatus, _perDaySprintActivitySave);
			obj.Save();
			Assert.InRange(obj.AvailableHours,0.1,100 );
		}

		[Fact]
		public void PerDaySprintActivity_Save_SaveTheDataSuccessfully()
		{
			MeetingStatus meetingStatus = new MeetingStatus
			{
				AttendeenceStatus = "FullDay",
				IsBillingAndKpiAttended = true,
				IsBsdAttended = true,
				IsIgrowAttended = true
			};
			var perDaySprintActivityInputWrapper = new Mock<IPerDaySprintActivityInputWrapper>();
			var perDaySprintActivitySave = new Mock<IPerDaySprintActivitySave>();
			
			var obj = new PerDaySprintActivity(perDaySprintActivityInputWrapper.Object,meetingStatus,perDaySprintActivitySave.Object);
			obj.Save();

			perDaySprintActivitySave.Verify(item => item.Save(It.IsAny<PerDaySprintActivity>()),Times.Once);



		}

	}

}
