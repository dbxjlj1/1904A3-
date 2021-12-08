using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Dto.GoodsDto
{
    /// <summary>
    /// 规格
    /// </summary>
    public class SpecificationDto
    {
        public Guid sp_id { get; set; }//规格id
        public string sp_color { get; set; }//颜色
        public string sp_edition { get; set; }//版本
        public decimal sp_weight { get; set; }//重量
        public string sp_size { get; set; }//大小/尺寸

    }
}
