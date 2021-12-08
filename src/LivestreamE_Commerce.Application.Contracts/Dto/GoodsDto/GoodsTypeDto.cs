using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Dto.GoodsDto
{
    /// <summary>
    /// 商品类型表
    /// </summary>
    public class GoodsTypeDto
    {
        public Guid gt_id { get; set; }
        public Guid go_id { get; set; }//商品id
        public Guid ty_id { get; set; }//类型id

    }
}
