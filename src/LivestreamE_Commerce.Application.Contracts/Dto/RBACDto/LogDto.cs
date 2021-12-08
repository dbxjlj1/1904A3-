using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Dto.RBACDto
{
    public class LogDto 
    {
        public Guid log_id { get; set; }//日志id
        public int op_type { get; set; }//操作类型
        public string content { get; set; }//操作内容
        public Guid tu_id { get; set; }//操作人
        public DateTime gen_time { get; set; } = DateTime.Now;//操作时间

    }
}
