using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Total_Auto_Model.JcyCardModel;
using Total_Auto_BLL;

namespace Total_Auto_API.Controllers
{
    [ApiController]
    public class JcyCardsController : ControllerBase
    {

        JcyCardBLL bll = new JcyCardBLL();
        /// <summary>
        /// 查询品牌
        /// </summary>
        /// <returns></returns>.
        [Route("api/[controller]/BrandsList")]
        [HttpGet]
        public Task<List<Brand>> BrandsList()
        {
            return bll.BrandsList();
        }
        /// <summary>
        /// 根据id查询品牌对应的车系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/[controller]/CarSeriesList")]
        [HttpGet]
        public Task<List<CarSeries>> CarSeriesList(int id = 0)
        {
            return bll.CarSeriesList(id);
        }
        /// <summary>
        /// 获取变速箱下拉
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/[controller]/GearboxList")]
        [HttpGet]
        public Task<List<Gearbox>> GearboxList()
        {
            return bll.GearboxList();
        }
        /// <summary>
        /// 获取车型下拉
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/CarsVisonList")]
        [HttpGet]
        public Task<List<CarsVison>> CarsVisonList()
        {
            return bll.CarsVisonList();
        }
        /// <summary>
        /// 获取里程下拉
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/MileageList")]
        [HttpGet]
        public Task<List<Mileage>> MileageList()
        {
            return bll.MileageList();
        }
        /// <summary>
        /// 获取排量下拉
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/DisplacementList")]
        [HttpGet]
        public Task<List<Displacement>> DisplacementList()
        {
            return bll.DisplacementList();
        }
        /// <summary>
        /// 获取排放标准
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/DischargenormList")]
        [HttpGet]
        public Task<List<Dischargenorm>> DischargenormList()
        {
            return bll.DischargenormList();
        }
        /// <summary>
        /// 获取座位数
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/SeatnumList")]
        [HttpGet]
        public Task<List<Seatnum>> SeatnumList()
        {
            return bll.SeatnumList();
        }
        /// <summary>
        /// 获取燃油类型
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/FuelTypeList")]
        [HttpGet]
        public Task<List<FuelType>> FuelTypeList()
        {
            return bll.FuelTypeList();
        }
        /// <summary>
        /// 获取颜色
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/ColorsList")]
        [HttpGet]
        public Task<List<Colors>> ColorsList()
        {
            return bll.ColorsList();
        }
        /// <summary>
        /// 获取车牌所在地
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/CarnumlocationList")]
        [HttpGet]
        public Task<List<Carnumlocation>> CarnumlocationList()
        {
            return bll.CarnumlocationList();
        }
        /// <summary>
        /// 获取驱动类型
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/DriveTypeList")]
        [HttpGet]
        public Task<List<DriveType>> DriveTypeList()
        {
            return bll.DriveTypeList();
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/CountryDistinctList")]
        [HttpGet]
        public Task<List<CountryDistinct>> CountryDistinctList()
        {
            return bll.CountryDistinctList();
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/BrightConfigList")]
        [HttpGet]
        public Task<List<BrightConfig>> BrightConfigList()
        {
            return bll.BrightConfigList();
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/HotSizerList")]
        [HttpGet]
        public Task<List<HotSizer>> HotSizerList()
        {
            return bll.HotSizerList();
        }
    }
}
