using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace LivestreamE_Commerce.Model.RBAC
{
    public class LogModel :AuditedAggregateRoot<Guid>
    {
        public int OperationType { get; set; }//操作类型
        public string Content { get; set; }//操作内容
        public Guid UserId { get; set; }//操作人
        public DateTime GenTime { get; set; } = DateTime.Now;//操作时间

    }
}
