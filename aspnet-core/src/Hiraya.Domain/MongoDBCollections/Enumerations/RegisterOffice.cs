using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    public enum RegisterOffice
    {
        [Display ( Name = "Head Office", Description = "Head Office")]
        HeadOffice = 0,

        [Display(Name = "Branch Office", Description = "Branch Office")]
        BranchOffice = 1,

        [Display(Name = "Facility", Description = "Facility")]
        Facility = 2

    }
}
