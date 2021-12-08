using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Model.Goods
{
    /// <summary>
    /// 用户图片
    /// </summary>

    public class UserImgModel
    {
        [Key]
        public Guid ui_id { get; set; }
        public Guid us_id { get; set; }//用户id
        public Guid im_id { get; set; }//图片id

    }
}
