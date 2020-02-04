using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    public enum CivilStatus
    {
        [Display ( Name = "Single", Description = "Single")]
        Single = 0,

        [Display(Name = "Married", Description = "Married")]
        Married = 1,

        [Display(Name = "Widow", Description = "Widow")]
        Widow = 2,

        [Display(Name = "Legally Separated", Description = "Legally Separated")]
        LegallySeparated = 3

    }
}
