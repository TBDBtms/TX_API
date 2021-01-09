using System;
using System.Collections.Generic;
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
        /// 根据id查询品牌对应的车系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarSeries> CarSeriesList(int id=0)
        {
            string str = $"select b.CarserName from Brand a JOIN CarSeries b on a.BrandId=b.BrandId where 1=1 and a.BrandId={id}";
            return JcyDBHelper.GetList<CarSeries>(str);
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
