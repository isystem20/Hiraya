using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    public enum AccountingPeriod
    {
        [Display ( Name = "Calendar Year", Description = "Calendar Year")]
        CalendarYear = 0,

        [Display(Name = "Fiscal Year", Description = "Fiscal Year")]
        FiscalYear = 1,

    }
}
