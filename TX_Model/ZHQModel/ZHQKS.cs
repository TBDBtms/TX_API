using System;
using System.Collections.Generic;
using System.Text;

namespace Total_Auto_Model.ZHQModel
{
   public class ZHQKS
    {
        //    ZHQKSId int primary key auto_increment,  -- 车型款式表主键
        public int ZHQKSId { get; set; }
        //ZHQKSName varchar(50)-- 车型款式名称
        public string ZHQKSName { get; set; }

    }
}
