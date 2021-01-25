using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Total_Auto_BLL;
using Total_Auto_Model.ZHQModel;

namespace Total_Auto_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ZHQ_GJCountController : ControllerBase
    {
        ZHQ_GJCountBLL bll = new ZHQ_GJCountBLL();

        /// <summary>
        /// 修改估价人数
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int UpdCount()
        {
            return bll.UpdCount();
        }
        /// <summary>
        /// 查询估价人数
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public GJCountTable GetCount()
        {
            return bll.GetCount();
        }
        /// <summary>
        /// 查询品牌
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult GetBrand()
        {
            return Ok(bll.GetBrand());
        }
        /// <summary>
        /// 根据品牌查询车型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult GetCX(int id)
        {
            return Ok(bll.GetCX(id));
        }
        /// <summary>
        /// 查询车辆款式
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult GetKS()
        {
            return Ok(bll.GetKS());
        }
     
    }
}
