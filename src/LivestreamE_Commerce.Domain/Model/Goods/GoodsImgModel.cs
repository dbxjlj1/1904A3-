using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Model.Goods
{
    /// <summary>
    /// 商品图片
    /// </summary>
    public class GoodsImgModel
    {
        [Key]
        public Guid gi_id { get; set; }
        public Guid go_id { get; set; }//商品id
        public Guid im_id { get; set; }//图片id

    }
}
