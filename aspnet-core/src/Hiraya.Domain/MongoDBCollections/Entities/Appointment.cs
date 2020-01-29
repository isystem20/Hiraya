using Abp.Domain.Entities.Auditing;
using Hiraya.Domain.MongoDBCollections.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    public class Appointment : AuditedEntity
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string BussinesPurpose { get; set; }
        public string Notes { get; set; }
        public DateTime StartDate { get; set; } //Startdate of appointment
        public DateTime EndDate { get; set; } //Startdate of appointment
        public Status Status { get; set; } //Finished
        
    }
}
