using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using ProBilling.ReportGenerationLogic;
using Moq;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;

namespace ProBillingV1._1
{
	public class UnitTest1
	{
		[Fact]
		public void ScrumMaster_AttendenceGettingFilledSuccessfully()
		{
			var obj = new xyz();
			string result = obj.FillAttendance();
			Assert.Equal("FullDay", result);
		}

		

		[Fact]
		public void test_test_test()
		{
			var userId = 1;
			var sprintId = 1;
			var teamId = 1;
			var date = DateTime.Now.Date;
			var isBillingAndKpiAttended = true;
			var isBsdAttended = true;
			var isIgrowAttended = true;
			var isManagemenetMeetingAttended = true;
			var isSmfAttended = true;
			var isSosAttended = true;
			var isTechTalkAttended = true;
			var isWowAttended = true;
			var attendeenceStatus = "FullDay";

			var obj = new abc(userId, sprintId,teamId,date,isBillingAndKpiAttended,isBsdAttended,isIgrowAttended,isManagemenetMeetingAttended,
				isSmfAttended,isSosAttended,isTechTalkAttended,isWowAttended,attendeenceStatus);
			
		}



	}

	internal class abc
	{
		public int UserId { get; }
		public int SprintId { get; }
		public int TeamId { get; }
		public DateTime Time { get; }
		private readonly bool _isBillingAndKpiAttended;
		private readonly bool _isBsdAttended;
		private readonly bool _isIgrowAttended;
		private readonly bool _isManagemenetMeetingAttended;
		private readonly bool _isSmfAttended;
		private readonly bool _isSosAttended;
		private readonly bool _isTechTalkAttended;
		private readonly bool _isWowAttended;
		private readonly string _attendeenceStatus;

		public float CompanyMeetingHours { get; set; }
		public float AvailableHours { get; set; }

		public abc(int userId, int sprintId, int teamId, DateTime date, bool isBillingAndKpiAttended, bool isBsdAttended, bool isIgrowAttended, bool isManagemenetMeetingAttended, bool isSmfAttended, bool isSosAttended, bool isTechTalkAttended, bool isWowAttended, string attendeenceStatus)
		{
			_attendeenceStatus = attendeenceStatus;
			_isWowAttended = isWowAttended;
			_isTechTalkAttended = isTechTalkAttended;
			_isSosAttended = isSosAttended;
			_isSmfAttended = isSmfAttended;
			_isManagemenetMeetingAttended = isManagemenetMeetingAttended;
			_isIgrowAttended = isIgrowAttended;
			_isBsdAttended = isBsdAttended;
			_isBillingAndKpiAttended = isBillingAndKpiAttended;
			Time = date;
			TeamId = teamId;
			SprintId = sprintId;
			UserId = userId;
		}

		
		


	}


	internal class xyz
	{
		public xyz()
		{
		}



		internal string FillAttendance()
		{
			return "FullDay";
		}


	}


}
