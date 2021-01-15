using System;
using System.Collections.Generic;
using System.Text;

namespace Total_Auto_Model.JcyCardModel
{
    /// <summary>
    /// 车辆信息
    /// </summary>
    public class CardInfo
    {
        /// <summary>
        /// 车辆id
        /// </summary>
        public int CardId { get; set; }
        /// <summary>
        /// 车辆名称
        /// </summary>
        public string CardName { get; set; }
        /// <summary>
        /// 车龄
        /// </summary>
        public int YearAge { get; set; }
        /// <summary>
        /// 公里数
        /// </summary>
        public decimal KMNum { get; set; }
        /// <summary>
        /// 上牌时间
        /// </summary>
        public DateTime CardTime { get; set; }
        /// <summary>
        /// 服务
        /// </summary>
        public string CardHelp { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 查询选项
        /// </summary>
        public string CardChange { get; set; }
        /// <summary>
        /// 上架时间
        /// </summary>
        public DateTime?CardTimes { get; set; }
        /// <summary>
        /// 车系id
        /// </summary>
        public int CarserId { get; set; }
        /// <summary>
        /// 品牌id
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// 车龄
        /// </summary>
        public int AgeId { get; set; }
        /// <summary>
        /// 变速箱
        /// </summary>
        public int GearboxId { get; set; }
        /// <summary>
        /// 车型
        /// </summary>
        public int CarsVisonId { get; set; }
        /// <summary>
        /// 里程
        /// </summary>
        public int MileageId { get; set; }
        /// <summary>
        /// 排量
        /// </summary>
        public int DisplacementId { get; set; }
        /// <summary>
        /// 排放标准
        /// </summary>
        public int DisId { get; set; }
        /// <summary>
        /// 座位数
        /// </summary>
        public int SeatnumId { get; set; }
        /// <summary>
        /// 燃油类型
        /// </summary>
        public int FuelTypeId { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public int ColorId { get; set; }
        /// <summary>
        /// 车牌所在地
        /// </summary>
        public int CarnumId { get; set; }
        /// <summary>
        /// 驱动类型
        /// </summary>
        public int DriveTypeId { get; set; }
        /// <summary>
        /// 国别
        /// </summary>
        public int CountryDisId { get; set; }
        /// <summary>
        /// 亮点配置
        /// </summary>
        public int ConfigId { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string PhotoCar { get; set; }
        /// <summary>
        /// 排量name
        /// </summary>
        public string DisplacementName { get; set; }
        /// <summary>
        /// 变速箱name
        /// </summary>
        public string GearboxName { get; set; }

        public string TopPhoto { get; set; }
        public string LeftPhoto { get; set; }
        public string RightPhoto { get; set; }
        public string DownPhoto { get; set; }
        public string Qphoto { get; set; }
    }
}
