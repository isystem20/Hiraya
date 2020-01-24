using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Enumerations
{
    public enum ReminderType
    {
        Private = 0,
        Common = 1,
        Custom = 2,
        Appointment = 3,
        Important = 4
    }
}
