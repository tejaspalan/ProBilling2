using System;
using System.Collections.Generic;
using System.Text;

namespace ProBilling.ReportGenerationLogic.Class
{
    public class MeetingStatus
    {
	    public bool IsBillingAndKpiAttended { get; set; }
	    public bool IsBsdAttended { get; set; }
	    public bool IsIgrowAttended { get; set; }
	    public bool IsManagemenetMeetingAttended { get; set; }
	    public bool IsSmfAttended { get; set; }
	    public bool IsSosAttended { get; set; }
	    public bool IsTechTalkAttended { get; set; }
	    public bool IsWowAttended { get; set; }
	    public string AttendeenceStatus { get; set; }
	}
}
