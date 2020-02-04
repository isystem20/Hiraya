using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    public enum MannerOfPayment
    {
        SelfAssessment = 1,
        TaxDepositOrAdvancePayment = 2,
        IncomeTaxSecondInstallment = 3,
        Penalties = 4,
        PreliminaryOrFinalAssessmentOrDeficiencyTax = 5,
        AccountsReceivableOrDelinquentAccount = 6
    }
}
