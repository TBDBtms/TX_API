using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Total_Auto_Model;
using Total_Auto_Model.JcyCardModel;

namespace Total_Auto_DAL
{
    public class JcyCardDAL
    {
        /// <summary>
        /// 查询品牌
        /// </summary>
        /// <returns></returns>
        public List<Brand> BrandsList()
        {
            string str = $"select * from Brand ORDER BY BrandId DESC LIMIT 10";
            return JcyDBHelper.GetList<Brand>(str);
        }
        /// <summary>
        /// 车系数据
        /// </summary>
        /// <returns></returns>
        public List<CarSeries> GetCards()
        {
            string str = $"select * from CarSeries LIMIT 10";
            return JcyDBHelper.GetList<CarSeries>(str);
        }
        /// <summary>
        /// 随机获取车系数据
        /// </summary>
        /// <returns></returns>
        public List<CarSeries> GetCarSeries()
        {
            string str = $"SELECT * FROM CarSeries WHERE CarserId >= (SELECT floor(RAND() * (SELECT MAX(CarserId) FROM CarSeries))) ORDER BY CarserId LIMIT 0,8";
            return JcyDBHelper.GetList<CarSeries>(str);
        }
        /// <summary>
        /// 根据id查询品牌对应的车系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarSeries> CarSeriesList(int id = 0)
        {
            string str = $"select b.CarserName from Brand a JOIN CarSeries b on a.BrandId=b.BrandId where 1=1 and a.BrandId={id}";
            return JcyDBHelper.GetList<CarSeries>(str);
        }
        /// <summary>
        /// 品牌查询数据
        /// </summary>
        /// <param name="ppname"></param>
        /// <returns></returns>
        public List<CardInfo> CardInfoPPList(string ppname = "")
        {
            string str = $"select * from CardInfo a join Brand b on a.BrandId=b.BrandId where 1=1";
            if (!string.IsNullOrEmpty(ppname))
            {
                str += $" and a.BrandName like '%{ppname}%'";
            }
            return JcyDBHelper.GetList<CardInfo>(str);
        }
        /// <summary>
        /// 车系查询数据
        /// </summary>
        /// <param name="cxname"></param>
        /// <returns></returns>
        public List<CardInfo> CardInfoCxList(string cxname = "")
        {
            string str = $"select * from CardInfo a join CarSeries b on a.CarserId=b.CarserId where 1=1";
            if (!string.IsNullOrEmpty(cxname))
            {
                str += $" and a.CarserName like '%{cxname}%'";
            }
            return JcyDBHelper.GetList<CardInfo>(str);
        }
        /// <summary>
        /// 获取价格区间
        /// </summary>
        /// <returns></returns>
        public List<CarsPrice> GetPrices()
        {
            string str = $"select * from  CarsPrice";
            return JcyDBHelper.GetList<CarsPrice>(str);
        }
        /// <summary>
        /// 返填车辆信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CardInfo ShowCardId(int id)
        {
            try
            {
                string str = $"select * from CardInfo a join  CarAge b on a.AgeId = b.AgeId join Gearbox c on a.GearboxId = c.GearboxId join  CarsVison d on a.CarsVisonId = d.CarsVisonId join  Mileage e on a.MileageId = e.MileageId join Displacement f on a.DisplacementId = f.DisplacementId join Dischargenorm g on a.DisId = g.DisId join Seatnum h on a.SeatnumId = h.SeatnumId join FuelType i on a.FuelTypeId = i.FuelTypeId JOIN  Colors j on a.ColorId = j.ColorId join Carnumlocation k on a.CarnumId = k.CarnumId join DriveType l on a.DriveTypeId = l.DriveTypeId join CountryDistinct m on a.CountryDisId = m.CountryDisId join BrightConfig n on a.ConfigId = n.ConfigId join Brand o on a.BrandId=o.BrandId join CarSeries p on a.CarserId=p.CarserId join CardPhoto z on a.CardId=z.PhotoId  where a.CardId={id}";
                var list = JcyDBHelper.GetList<CardInfo>(str).ToList();
                if (list.Count > 0)
                {
                    return list.First();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 查询下拉框获取车辆数据
        /// </summary>
        /// <param name="agecard"></param>
        /// <param name="bsx"></param>
        /// <param name="cx"></param>
        /// <param name="kms"></param>
        /// <param name="pl"></param>
        /// <param name="pfbz"></param>
        /// <param name="zws"></param>
        /// <param name="rylx"></param>
        /// <param name="color"></param>
        /// <param name="cardszd"></param>
        /// <param name="qdlx"></param>
        /// <param name="countryb"></param>
        /// <param name="lightCoig"></param>
        /// <returns></returns>
        public List<CardInfo> CardInfoCofigList(string name = "", int brandId = 0, int CardId = 0, int priceId = 0, decimal startprice = 0, decimal endprice = 0, int agecard = 0, int bsx = 0, int cx = 0, int kms = 0, int pl = 0, int pfbz = 0, int zws = 0, int rylx = 0, int color = 0, int cardszd = 0, int qdlx = 0, int countryb = 0, int lightCoig = 0)
        {
            string str = $"select * from CardInfo a join  CarAge b on a.AgeId = b.AgeId join Gearbox c on a.GearboxId = c.GearboxId join  CarsVison d on a.CarsVisonId = d.CarsVisonId join  Mileage e on a.MileageId = e.MileageId join Displacement f on a.DisplacementId = f.DisplacementId join Dischargenorm g on a.DisId = g.DisId join Seatnum h on a.SeatnumId = h.SeatnumId join FuelType i on a.FuelTypeId = i.FuelTypeId JOIN  Colors j on a.ColorId = j.ColorId join Carnumlocation k on a.CarnumId = k.CarnumId join DriveType l on a.DriveTypeId = l.DriveTypeId join CountryDistinct m on a.CountryDisId = m.CountryDisId join BrightConfig n on a.ConfigId = n.ConfigId join Brand o on a.BrandId=o.BrandId join CarSeries p on a.CarserId=p.CarserId  where 1 = 1";
            if (!string.IsNullOrEmpty(name))
            {
                str += $" and a.CardName like '%{name}%'";
            }
            if (brandId > 0)
            {
                str += $" and o.BrandId={brandId}";
            }
            if (CardId > 0)
            {
                str += $" and p.CarserId={CardId}";
            }
            if (priceId > 0 && priceId == 1)
            {
                str += $" and a.Price<=3";
            }
            if (priceId > 0 && priceId == 2)
            {
                str += $" and a.Price >= 3 and a.Price<=5";
            }
            if (priceId > 0 && priceId == 3)
            {
                str += $" and a.Price>= 5 and a.Price<=7";
            }
            if (priceId > 0 && priceId == 4)
            {
                str += $" and a.Price>=7 and a.Price<=9";
            }
            if (priceId > 0 && priceId == 5)
            {
                str += $" and a.Price>=9 and a.Price<=12";
            }
            if (priceId > 0 && priceId == 6)
            {
                str += $" and a.Price>=12 and a.Price<=16";
            }
            if (priceId > 0 && priceId == 7)
            {
                str += $" and a.Price>=16 and a.Price<=20";
            }
            if (priceId > 0 && priceId == 8)
            {
                str += $" and a.Price>20";
            }
            if (startprice > 0 && endprice > 0)
            {
                str += $" and a.Price between {startprice} and {endprice}";
            }
            if (agecard > 0)
            {
                str += $"  and b.AgeId={agecard}";
            }
            if (bsx > 0)
            {
                str += $" and c.GearboxId={bsx}";
            }
            if (cx > 0)
            {
                str += $" and d.CarsVisonId={cx}";
            }
            if (kms > 0)
            {
                str += $" and e.MileageId={kms}";
            }
            if (pl > 0)
            {
                str += $" and f.DisplacementId={pl}";
            }
            if (pfbz > 0)
            {
                str += $" and g.DisId={pfbz}";
            }
            if (zws > 0)
            {
                str += $" and h.SeatnumId={zws}";
            }
            if (rylx > 0)
            {
                str += $" and i.FuelTypeId={rylx}";
            }
            if (color > 0)
            {
                str += $" and j.ColorId={color}";
            }
            if (cardszd > 0)
            {
                str += $" and k.CarnumId={cardszd}";
            }
            if (qdlx > 0)
            {
                str += $" and l.DriveTypeId={qdlx}";
            }
            if (countryb > 0)
            {
                str += $" and m.CountryDisId={countryb}";
            }
            if (lightCoig > 0)
            {
                str += $" and n.ConfigId={lightCoig}";
            }
            return JcyDBHelper.GetList<CardInfo>(str);
        }
        /// <summary>
        /// 获取变速箱下拉
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Gearbox> GearboxList()
        {
            string str = $"select * from Gearbox";
            return JcyDBHelper.GetList<Gearbox>(str);
        }
        /// <summary>
        /// 获取车型下拉
        /// </summary>
        /// <returns></returns>
        public Task<List<CarsVison>> CarsVisonList()
        {
            string str = $"select * from CarsVison";
            return Task.FromResult(JcyDBHelper.GetList<CarsVison>(str));
        }
        /// <summary>
        /// 获取里程下拉
        /// </summary>
        /// <returns></returns>
        public Task<List<Mileage>> MileageList()
        {
            string str = $"select * from Mileage";
            return Task.FromResult(JcyDBHelper.GetList<Mileage>(str));
        }
        /// <summary>
        /// 获取排量下拉
        /// </summary>
        /// <returns></returns>
        public Task<List<Displacement>> DisplacementList()
        {
            string str = $"select * from Displacement";
            return Task.FromResult(JcyDBHelper.GetList<Displacement>(str));
        }
        /// <summary>
        /// 获取排放标准
        /// </summary>
        /// <returns></returns>
        public Task<List<Dischargenorm>> DischargenormList()
        {
            string str = $"select * from Dischargenorm";
            return Task.FromResult(JcyDBHelper.GetList<Dischargenorm>(str));
        }
        /// <summary>
        /// 获取座位数
        /// </summary>
        /// <returns></returns>
        public Task<List<Seatnum>> SeatnumList()
        {
            string str = $"select * from Seatnum";
            return Task.FromResult(JcyDBHelper.GetList<Seatnum>(str));
        }
        /// <summary>
        /// 获取燃油类型
        /// </summary>
        /// <returns></returns>
        public Task<List<FuelType>> FuelTypeList()
        {
            string str = $"select * from FuelType";
            return Task.FromResult(JcyDBHelper.GetList<FuelType>(str));
        }
        /// <summary>
        /// 获取颜色
        /// </summary>
        /// <returns></returns>
        public Task<List<Colors>> ColorsList()
        {
            string str = $"select * from Colors";
            return Task.FromResult(JcyDBHelper.GetList<Colors>(str));
        }
        /// <summary>
        /// 获取车牌所在地
        /// </summary>
        /// <returns></returns>
        public Task<List<Carnumlocation>> CarnumlocationList()
        {
            string str = $"select * from Carnumlocation";
            return Task.FromResult(JcyDBHelper.GetList<Carnumlocation>(str));
        }
        /// <summary>
        /// 获取驱动类型
        /// </summary>
        /// <returns></returns>
        public Task<List<DriveType>> DriveTypeList()
        {
            string str = $"select * from DriveType";
            return Task.FromResult(JcyDBHelper.GetList<DriveType>(str));
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        public Task<List<CountryDistinct>> CountryDistinctList()
        {
            string str = $"select * from CountryDistinct";
            return Task.FromResult(JcyDBHelper.GetList<CountryDistinct>(str));
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        public Task<List<BrightConfig>> BrightConfigList()
        {
            string str = $"select * from CountryDistinct";
            return Task.FromResult(JcyDBHelper.GetList<BrightConfig>(str));
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        public Task<List<HotSizer>> HotSizerList()
        {
            string str = $"select * from HotSizer";
            return Task.FromResult(JcyDBHelper.GetList<HotSizer>(str));
        }

    }
}
