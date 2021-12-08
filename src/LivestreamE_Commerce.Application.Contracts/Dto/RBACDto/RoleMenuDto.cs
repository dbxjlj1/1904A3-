using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LivestreamE_Commerce.Dto.RBACDto
{
    public class RoleMenuDto
    {
        public Guid tro_id { get; set; }
        public Guid tr_id { get; set; }//角色id
        public Guid tm_id { get; set; }//权限id

    }
}
