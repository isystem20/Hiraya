using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    /// <summary>
    /// Regardless of a company's financial year, it must also have a tax year when filing income tax returns. The tax year follows the calendar year or a company's fiscal year. However, a company may have a short or non-existent tax year if it has not existed for 12 months when filing tax returns or it changed its accounting period. Once a company adopts a tax year, the BIR has to approve any changes a company wishes to make.
    /// </summary>
    public enum YearType
    {
        /// <summary>
        /// Calendar year is a period of 12 months, which begin on January 1 and end on December 31
        /// </summary>
        Calendar = 1,
        /// <summary>
        /// A fiscal year also contains 12 consecutive months, but can end on the last day of any month, with the exception of December.
        /// </summary>
        Fiscal = 2
    }
}
