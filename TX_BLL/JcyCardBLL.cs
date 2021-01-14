using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Total_Auto_DAL;
using Total_Auto_Model;
using Total_Auto_Model.JcyCardModel;

namespace Total_Auto_BLL
{
    public class JcyCardBLL
    {
        JcyCardDAL dal = new JcyCardDAL();
        /// <summary>
        /// 查询品牌
        /// </summary>
        /// <returns></returns>
        public List<Brand> BrandsList()
        {
            return dal.BrandsList();
        }
        /// <summary>
        /// 根据id查询品牌对应的车系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarSeries> CarSeriesList(int id = 0)
        {
            return dal.CarSeriesList(id);
        }
        /// <summary>
        /// 随机获取8条车系数据
        /// </summary>
        /// <returns></returns>
        public List<CarSeries> GetCarSeries()
        {
            string str = $"SELECT * FROM CarSeries WHERE CarserId >= (SELECT floor(RAND() * (SELECT MAX(CarserId) FROM CarSeries))) ORDER BY CarserId LIMIT 0,8";
            return JcyDBHelper.GetList<CarSeries>(str);
        }
        /// <summary>
        /// 品牌查询数据
        /// </summary>
        /// <param name="ppname"></param>
        /// <returns></returns>
        public List<CardInfo> CardInfoPPList(string ppname = "")
        {
            return dal.CardInfoPPList(ppname);
        }
        /// <summary>
        /// 车系查询数据
        /// </summary>
        /// <param name="cxname"></param>
        /// <returns></returns>
        public List<CardInfo> CardInfoCxList(string cxname = "")
        {
            return dal.CardInfoCxList(cxname);
        }
        /// <summary>
        /// 查询下拉框
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
            return dal.CardInfoCofigList(name,brandId,CardId,priceId,startprice,endprice,agecard,bsx,cx,kms,pl,pfbz,zws,rylx,color,cardszd,qdlx,countryb,lightCoig);
        }
        /// <summary>
        /// 返填车辆信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CardInfo ShowCardId(int id)
        {
            return dal.ShowCardId(id);
        }
        /// <summary>
        /// 获取价格区间
        /// </summary>
        /// <returns></returns>
        public List<CarsPrice> GetPrices()
        {
            return dal.GetPrices();
        }
        /// <summary>
        /// 获取变速箱下拉
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Gearbox> GearboxList()
        {
            return dal.GearboxList();
        }
        /// <summary>
        /// 获取车型下拉
        /// </summary>
        /// <returns></returns>
        public Task<List<CarsVison>> CarsVisonList()
        {
            return dal.CarsVisonList();
        }
        /// <summary>
        /// 车系数据
        /// </summary>
        /// <returns></returns>
        public List<CarSeries> GetCards()
        {
            return dal.GetCards();
        }
        /// <summary>
        /// 获取里程下拉
        /// </summary>
        /// <returns></returns>
        public Task<List<Mileage>> MileageList()
        {
            return dal.MileageList();
        }
        /// <summary>
        /// 获取排量下拉
        /// </summary>
        /// <returns></returns>
        public Task<List<Displacement>> DisplacementList()
        {
            return dal.DisplacementList();
        }
        /// <summary>
        /// 获取排放标准
        /// </summary>
        /// <returns></returns>
        public Task<List<Dischargenorm>> DischargenormList()
        {
            return dal.DischargenormList();
        }
        /// <summary>
        /// 获取座位数
        /// </summary>
        /// <returns></returns>
        public Task<List<Seatnum>> SeatnumList()
        {
            return dal.SeatnumList();
        }
        /// <summary>
        /// 获取燃油类型
        /// </summary>
        /// <returns></returns>
        public Task<List<FuelType>> FuelTypeList()
        {
            return dal.FuelTypeList();
        }
        /// <summary>
        /// 获取颜色
        /// </summary>
        /// <returns></returns>
        public Task<List<Colors>> ColorsList()
        {
            return dal.ColorsList();
        }
        /// <summary>
        /// 获取车牌所在地
        /// </summary>
        /// <returns></returns>
        public Task<List<Carnumlocation>> CarnumlocationList()
        {
            return dal.CarnumlocationList();
        }
        /// <summary>
        /// 获取驱动类型
        /// </summary>
        /// <returns></returns>
        public Task<List<DriveType>> DriveTypeList()
        {
            return dal.DriveTypeList();
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        public Task<List<CountryDistinct>> CountryDistinctList()
        {
            return dal.CountryDistinctList();
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        public Task<List<BrightConfig>> BrightConfigList()
        {
            return dal.BrightConfigList();
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        public Task<List<HotSizer>> HotSizerList()
        {
            return dal.HotSizerList();
        }
    }
}
