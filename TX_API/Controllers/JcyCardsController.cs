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
        public IActionResult BrandsList()
        {
            return Ok(bll.BrandsList());
        }
        /// <summary>
        /// 根据id查询品牌对应的车系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/[controller]/CarSeriesList")]
        [HttpGet]
        public IActionResult CarSeriesList(int id = 0)
        {
            return Ok(bll.CarSeriesList(id));
        }
        /// <summary>
        /// 获取变速箱下拉
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/[controller]/GearboxList")]
        [HttpGet]
        public IActionResult GearboxList()
        {
            return Ok(bll.GearboxList());
        }
        /// <summary>
        /// 车系数据
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/GetCards")]
        [HttpGet]
        public IActionResult GetCards()
        {
            return Ok(bll.GetCards());
        }
        /// <summary>
        /// 获取车型下拉
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/CarsVisonList")]
        [HttpGet]
        public IActionResult CarsVisonList()
        {
            return Ok(bll.CarsVisonList());
        }
        /// <summary>
        /// 获取里程下拉
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/MileageList")]
        [HttpGet]
        public IActionResult MileageList()
        {
            return Ok(bll.MileageList());
        }
        /// <summary>
        /// 获取排量下拉
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/DisplacementList")]
        [HttpGet]
        public IActionResult DisplacementList()
        {
            return Ok(bll.DisplacementList());
        }
        /// <summary>
        /// 获取排放标准
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/DischargenormList")]
        [HttpGet]
        public IActionResult DischargenormList()
        {
            return Ok(bll.DischargenormList());
        }
        /// <summary>
        /// 获取座位数
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/SeatnumList")]
        [HttpGet]
        public IActionResult SeatnumList()
        {
            return Ok(bll.SeatnumList());
        }
        /// <summary>
        /// 获取燃油类型
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/FuelTypeList")]
        [HttpGet]
        public IActionResult FuelTypeList()
        {
            return Ok(bll.FuelTypeList());
        }
        /// <summary>
        /// 获取颜色
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/ColorsList")]
        [HttpGet]
        public IActionResult ColorsList()
        {
            return Ok(bll.ColorsList());
        }
        /// <summary>
        /// 获取车牌所在地
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/CarnumlocationList")]
        [HttpGet]
        public IActionResult CarnumlocationList()
        {
            return Ok(bll.CarnumlocationList());
        }
        /// <summary>
        /// 获取驱动类型
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/DriveTypeList")]
        [HttpGet]
        public IActionResult DriveTypeList()
        {
            return Ok(bll.DriveTypeList());
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/CountryDistinctList")]
        [HttpGet]
        public IActionResult CountryDistinctList()
        {
            return Ok(bll.CountryDistinctList());
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/BrightConfigList")]
        [HttpGet]
        public IActionResult BrightConfigList()
        {
            return Ok(bll.BrightConfigList());
        }
        /// <summary>
        /// 获取国别
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/HotSizerList")]
        [HttpGet]
        public IActionResult HotSizerList()
        {
            return Ok(bll.HotSizerList());
        }
    }
}
