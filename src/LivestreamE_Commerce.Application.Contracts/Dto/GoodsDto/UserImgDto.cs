using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Dto.GoodsDto
{
    /// <summary>
    /// 用户图片
    /// </summary>

    public class UserImgDto
    {
        public Guid ui_id { get; set; }
        public Guid us_id { get; set; }//用户id
        public Guid im_id { get; set; }//图片id

    }
}
