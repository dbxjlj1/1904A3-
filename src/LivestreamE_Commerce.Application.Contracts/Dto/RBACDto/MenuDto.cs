using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LivestreamE_Commerce.Dto.RBACDto
{
    public class MenuDto
    {
        public Guid tm_id { get; set; } = new Guid();
        public Guid superiorid { get; set; }//上级id
        public string menu_name { get; set; }//权限名称
        public string description { get; set; }//权限描述

    }
}
