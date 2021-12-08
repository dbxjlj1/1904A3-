using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Dto.GoodsDto
{
    /// <summary>
    /// 商品规格
    /// </summary>
    public class GoodsSpecificationDto
    {
        public Guid gs_id { get; set; }
        public Guid go_id { get; set; }//商品id
        public Guid sp_id { get; set; }//规格id

    }
}
