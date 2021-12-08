using LivestreamE_Commerce.Dto.RBACDto;
using LivestreamE_Commerce.IService;
using LivestreamE_Commerce.Model.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace LivestreamE_Commerce.Service
{
    public class UserService : CrudAppService<UserModel, UserDto, Guid, PagedAndSortedResultRequestDto>,IUserService
    {
        public UserService(IRepository<UserModel,Guid> repository) : base(repository) 
        {
        
        }
    }
    
}
