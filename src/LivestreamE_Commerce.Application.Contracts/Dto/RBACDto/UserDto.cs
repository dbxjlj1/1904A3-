using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace LivestreamE_Commerce.Dto.RBACDto
{
    public class UserDto:AuditedEntityDto<Guid>
    {
        public string LiginName { get; set; }//登录账号
        public string Password { get; set; }//登录密码
        public string Vsername { get; set; }//姓名
        public string Phone { get; set; }//手机号
        public string Email { get; set; }//电子邮件
        public DateTime GenTime { get; set; } = DateTime.Now;//创建时间
        public DateTime LoginTime { get; set; }//登录时间
        public DateTime LastLoginTime { get; set; }//上次登录时间
        public string Count { get; set; }//登录次数


    }
}
