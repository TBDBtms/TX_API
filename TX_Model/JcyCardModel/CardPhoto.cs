using System;
using System.Collections.Generic;
using System.Text;

namespace Total_Auto_Model.JcyCardModel
{
    /// <summary>
    /// 车辆图片
    /// </summary>
    public class CardPhoto
    {
        public int PhotoId { get; set; }
        public string TopPhoto { get; set; }
        public string LeftPhoto { get; set; }
        public string RightPhoto { get; set; }
        public string DownPhoto { get; set; }
        public string Qphoto { get; set; }
    }
}
