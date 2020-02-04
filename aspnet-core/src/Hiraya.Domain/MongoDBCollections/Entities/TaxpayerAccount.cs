using Hiraya.Domain.MongoDBCollections.Enumerations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.Domain.MongoDBCollections.Entities
{
    /// <summary>
    /// Individual / Business Accounts of tax paying entity
    /// </summary>
    public class TaxpayerAccount
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string TaxIdentityNumber { get; set; }
        public long TaxpayerTypeId { get; set; }
        public RegisterOffice RegisterOffice { get; set; }
        public DateTime RegistrationDate { get; set; }
        public long RDOId { get; set; }

        #region Taxpayer Information Personal

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastNmae { get; set; }
        public string Suffix { get; set; } // Sr., Jr., III, etc ??

        public Gender Gender { get; set; }
        public CivilStatus CivilStatus { get; set; } // Sr., Jr., III, etc ??
        public DateTime BirthDate { get; set; } // Sr., Jr., III, etc ??
        public string PlaceOfBirth { get; set; } // Sr., Jr., III, etc ??
        public string Citizenship { get; set; }
        public string OtherCitizenship { get; set; }

        // Mother's Maiden Name
        public string MotherFirstName { get; set; }
        public string MotherMiddleName { get; set; }
        public string MotherLastNmae { get; set; }

        // Father's Maiden Name
        public string FatherFirstName { get; set; }
        public string FatherMiddleName { get; set; }
        public string FatherLastNmae { get; set; }
        
        #endregion

        #region Taxpayer Information

        public string RegisteredName { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime AccountingStartDate { get; set; }
        public AccountingPeriod AccountingPeriod { get; set; }
        public List<TaxpayerAccount> AuthorizedAgent { get; set; }

        #endregion

        #region Taxpayer Address

        public string BldgUnitInfo { get; set; } //Unit,Room,Floor, and Building Number
        public string BldgName { get; set; }
        public string LotBlockNo { get; set; } //Unit,Room,Floor, and Building Number
        public string AddressDescription { get; set; } //Street
        public string AddressDescription2 { get; set; } //Village, Subd, Zone
        public long RegionId { get; set; }
        public long ProvinceId { get; set; }
        public long MunicipalityId { get; set; }
        public long CityId { get; set; }
        public long BarangayId { get; set; }
        public string ZipCode { get; set; }

        public string ForeignAddress { get; set; }

        #endregion

        #region Taxpayer Contacts

        public string CountryCode { get; set; } //Country Code; +63, etc.
        public string Mobile { get; set; } //Country Code + Actual Number
        public string Landline { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }

        #endregion
        
    }
}
