using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivestreamE_Commerce.Dto.GoodsDto
{
    /// <summary>
    /// 图片表
    /// </summary>
    public class ImgDto
    {
        public Guid im_id { get; set; }//图片id
        public string im_url { get; set; }//图片路径
        public DateTime upl_time { get; set; } = DateTime.Now;//图片上传时间

    }
}
