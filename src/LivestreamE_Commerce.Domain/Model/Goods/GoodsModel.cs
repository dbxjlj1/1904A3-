using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Model.Goods
{
    /// <summary>
    /// 商品
    /// </summary>
    public class GoodsModel
    {
        [Key]
        public Guid tg_id { get; set; }//商品id
        public string goodsname { get; set; }//商品名称
        public decimal goodsprice { get; set; }//商品价格
        public string description { get; set; }//商品描述
        public int goodsnum { get; set; }//商品库存
        public bool goodsstate { get; set; }//商品状态
        public DateTime gen_time { get; set; }//创建时间

    }
}
