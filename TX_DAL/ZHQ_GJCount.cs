using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Total_Auto_Model.ZHQModel;

namespace Total_Auto_DAL
{
  public  class ZHQ_GJCount
    {
        /// <summary>
        /// 修改估价人数
        /// </summary>
        /// <returns></returns>
        public int UpdCount()
        {
            string sql = "update GJCountTable set GJCount=GJCount+1 where GJCountId=1";
            int row = ZHQDBhelper.CMD(sql);
            return row;
        }
       /// <summary>
       /// 查询估价人数
       /// </summary>
       /// <returns></returns>
        public GJCountTable GetCount()
        {
            string sql = "select GJCount from GJCountTable where GJCountId=1";
            var  list = ZHQDBhelper.GetList<GJCountTable>(sql).FirstOrDefault();
            return list;
        }

        /// <summary>
        /// 查询品牌
        /// </summary>
        /// <returns></returns>
        public List<ZHQBrand> GetBrand()
        {
            string sql = "select * from ZHQBrand";
            return ZHQDBhelper.GetList<ZHQBrand>(sql);
        }
        /// <summary>
        /// 根据品牌查询车型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ZHQCX> GetCX(int id) {
            string sql = $"select * from ZHQCX where ZHQBrandId={id}";
            return ZHQDBhelper.GetList<ZHQCX>(sql);
        }
        /// <summary>
        /// 查询车辆款式
        /// </summary>
        /// <returns></returns>
        public List<ZHQKS> GetKS()
        {
            string sql = "select * from ZHQKS";
            return ZHQDBhelper.GetList<ZHQKS>(sql);
        }
    }

}
