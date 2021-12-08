using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace LivestreamE_Commerce.Model.RBAC
{
    public class RoleModel
    {
        [Key]
        public Guid tr_id { get; set; } = new Guid();//角色id
        public Guid parent_tr_id { get; set; }//上级id
        public string role_name { get; set; }//角色名
        public DateTime gen_time { get; set; } = DateTime.Now;//创建时间
        public string description { get; set; }//角色描述

    }
}
