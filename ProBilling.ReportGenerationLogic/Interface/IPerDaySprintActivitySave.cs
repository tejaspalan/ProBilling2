using System;
using System.Collections.Generic;
using System.Text;
using ProBilling.ReportGenerationLogic.Class;

namespace ProBilling.ReportGenerationLogic.Interface
{
    public interface IPerDaySprintActivitySave
    {
	    void Save(PerDaySprintActivity perDaySprintActivity);
    }
}
