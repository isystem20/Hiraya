using Abp.Application.Services;
using Abp.Domain.Uow;
using Abp.ObjectMapping;
using Hiraya.BIR.Notices.Dto;
using Hiraya.Domain.MongoDBCollections.Entities;
using Hiraya.MongoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.BIR.Notices
{
    public class NoticeAppService : IApplicationService
    {

        private readonly HirayaMongoDbContext _mongoData;

        private readonly IObjectMapper _objectMapper;

        public NoticeAppService(HirayaMongoDbContext mongoData, IObjectMapper objectMapper)
        {
            _mongoData = mongoData;

            _objectMapper = objectMapper;

        }


        public async Task<NoticeDto> CreateAsync(CreateNoticeDto input)
        {

            var entity = _objectMapper.Map<Notice>(input);

            entity.Id = Guid.NewGuid().ToString();

            await _mongoData.Notices.InsertOneAsync(entity);

            var dto = _objectMapper.Map<NoticeDto>(entity);

            return dto;

        }

    }
}
