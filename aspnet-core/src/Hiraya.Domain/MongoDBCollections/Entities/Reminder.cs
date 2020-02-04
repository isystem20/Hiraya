using Hiraya.Domain.MongoDBCollections.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// This will be the content of the Calendar feature.
    /// </summary>
    public class Reminder : AuditedEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAllDay { get; set; }
        public DateTime AlertTime { get; set; }
        // Entity string that will be parsed
        public string TargetClass { get; set; }
        // If the TargetClass is parsed, TargetId will the identification based on the class
        public string TargetId { get; set; }
        // Creator of this Reminder
        public string Host { get; set; }
        // In case the host wants to invite anyone
        public string Invitee { get; set; }
        // Set by the Host
        public string NotifyThruEmail { get; set; }
    }
}
