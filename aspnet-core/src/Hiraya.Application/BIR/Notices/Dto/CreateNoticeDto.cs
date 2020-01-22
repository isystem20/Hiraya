using Abp.AutoMapper;
using Hiraya.Domain.MongoDBCollections.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.BIR.Notices.Dto
{
    [AutoMapTo(typeof(Notice))]
    public class CreateNoticeDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool isPublic { get; set; }
        public DateTime DisplayStart { get; set; }
        public DateTime DisplayEnd { get; set; }
    }
}
