using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace LivestreamE_Commerce.Model.RBAC
{
    public class OrganizationModel
    {
        [Key]
        public Guid to_id { get; set; }//组织id
        public Guid superiorid { get; set; }//上级id
        public string org_name { get; set; }//组织名称
        public DateTime gen_time { get; set; }//创建时间
        public string description { get; set; }//组织描述

    }
}
