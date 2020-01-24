using Hiraya.Domain.MongoDBCollections.Common;
using Hiraya.Domain.MongoDBCollections.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// Payment details linked to the transaction items. This contains the important information related to the payment transactions to BIR.
    /// </summary>
    public class Payment : AuditedEntity
    {
        public string FormCode { get; set; } 
        public string TaxpayerId { get; set; }
        public string TransactionId { get; set; } //Transaction item should have the timestamp, etc
        public YearType YearType { get; set; }
        public string YearEnded { get; set; }
        public YearQuarter Quarter { get; set; }
        public DateTime DueDate { get; set; }
        public string NoOfSheetsAttached { get; set; }
        public string ATC { get; set; } // Im not sure what this is.
        public DateTime ReturnPeriod { get; set; }
        public string TaxCode { get; set; }
        public string BCSNo { get; set; }
        public string TaxpayerIdentificationNumber { get; set; }
        public string RDOCode { get; set; }
        public string TaxpayerClassification { get; set; }
        public string LineOfBusinessOrOccupation { get; set; }
        // Though Taxpayer Id is already included here, for counter checking and for history tracking, I still included the taxpayer details.
        public string TaxpayerName { get; set; }
        public string RegisteredAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string ZipCode { get; set; }
        public MannerOfPayment MannerOfPayment { get; set; }
        public TypeOfPayment TypeOfPayment { get; set; }
        public int NumberOfInstallment { get; set; }

        
    }
}
