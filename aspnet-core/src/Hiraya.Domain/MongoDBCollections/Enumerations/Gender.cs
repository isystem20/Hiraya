using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    public enum Gender
    {
        [Display ( Name = "Male", Description = "Male")]
        Male = 0,

        [Display(Name = "Female", Description = "Female")]
        Female = 1

    }
}
