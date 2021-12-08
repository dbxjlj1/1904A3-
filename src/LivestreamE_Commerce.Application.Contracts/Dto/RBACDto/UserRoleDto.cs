using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Dto.RBACDto
{
    public class UserRoleDto
    {
        public Guid tug_id { get; set; }
        public Guid tu_id { get; set; }//用户id
        public Guid tr_id { get; set; }//角色id

    }
}
