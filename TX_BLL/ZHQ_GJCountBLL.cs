using System;
using System.Collections.Generic;
using System.Text;
using Total_Auto_DAL;
using Total_Auto_Model.ZHQModel;

namespace Total_Auto_BLL
{
  public  class ZHQ_GJCountBLL
    {
        ZHQ_GJCount dal = new ZHQ_GJCount();
        /// <summary>
        /// 修改估价人数
        /// </summary>
        /// <returns></returns>
        public int UpdCount()
        {
            return dal.UpdCount();
        }
        /// <summary>
        /// 查询估价人数
        /// </summary>
        /// <returns></returns>
        public GJCountTable GetCount()
        {
            return dal.GetCount();
        }
        /// <summary>
        /// 查询品牌
        /// </summary>
        /// <returns></returns>
        public List<ZHQBrand> GetBrand()
        {
            return dal.GetBrand();
        }
        /// <summary>
        /// 根据品牌查询车型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ZHQCX> GetCX(int id)
        {
            return dal.GetCX(id);
        }
        /// <summary>
        /// 查询车辆款式
        /// </summary>
        /// <returns></returns>
        public List<ZHQKS> GetKS()
        {
            return dal.GetKS();
        }
    }
}
