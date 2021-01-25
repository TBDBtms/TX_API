using System;
using System.Collections.Generic;
using System.Text;

namespace Total_Auto_Model.ZHQModel
{
   public class ZHQCX
    {
        //    ZHQCXId int primary key auto_increment,  -- 车型表主键
        public int ZHQCXId { get; set; }
        //ZHQCXName varchar(50),-- 车型名称
        public string ZHQCXName { get; set; }
        //ZHQBrandId int-- 关联品牌表

        public int ZHQBrandId { get; set; }
    }
}
