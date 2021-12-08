using LivestreamE_Commerce.Dto.RBACDto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LivestreamE_Commerce.IService
{
    public interface IUserService:ICrudAppService<UserDto,Guid,PagedAndSortedResultRequestDto>
    {

    }
}
