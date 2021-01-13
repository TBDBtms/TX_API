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
        /// 品牌查询数据
        /// </summary>
        /// <param name="ppname"></param>
        /// <returns></returns>
        [Route("api/[controller]/CardInfoPPList")]
        [HttpGet]
        public IActionResult CardInfoPPList(string ppname = "")
        {
            return Ok(bll.CardInfoPPList(ppname));
        }
        /// <summary>
        /// 车系查询数据
        /// </summary>
        /// <param name="cxname"></param>
        /// <returns></returns>
        [Route("api/[controller]/CardInfoCxList")]
        [HttpGet]
        public IActionResult CardInfoCxList(string cxname = "")
        {
            return Ok(bll.CardInfoCxList(cxname));
        }
        /// <summary>
        /// 随机获取8条车系数据
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/GetCarSeries")]
        [HttpGet]
        public IActionResult GetCarSeries()
        {
            return Ok(bll.GetCarSeries());
        }
        /// <summary>
        /// 获取价格区间
        /// </summary>
        /// <returns></returns>
        [Route("api/[controller]/GetPrices")]
        [HttpGet]
        public IActionResult GetPrices()
        {
            return Ok(bll.GetPrices());
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
        [Route("api/[controller]/CardInfoCofigList")]
        [HttpGet]
        public IActionResult CardInfoCofigList(string name = "", int brandId = 0, int CardId = 0, int priceId = 0, decimal startprice = 0, decimal endprice = 0, int agecard = 0, int bsx = 0, int cx = 0, int kms = 0, int pl = 0, int pfbz = 0, int zws = 0, int rylx = 0, int color = 0, int cardszd = 0, int qdlx = 0, int countryb = 0, int lightCoig = 0)
        {
            return Ok(bll.CardInfoCofigList(name, brandId, CardId, priceId, startprice, endprice, agecard, bsx, cx, kms, pl, pfbz, zws, rylx, color, cardszd, qdlx, countryb, lightCoig));
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
