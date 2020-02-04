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
    public class RevenueDistrictOffice
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Code { get; set; }

        #region Contacts

        public string CountryCode { get; set; } //Country Code; +63, etc.
        public string Mobile { get; set; } //Country Code + Actual Number
        public string Landline { get; set; }
        public string Fax { get; set; }

        #endregion

        #region Address

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

        #endregion
    }
}
