using System;
using System.Collections.Generic;
using System.Text;

namespace Total_Auto_Model.DLHLoginModel
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class Administrator
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int AdminId			 { get; set; }
        /// <summary>
        /// 管理员
        /// </summary>
        public string AdminName		 { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string AdminPhone	 { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string AdminPwd		 { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool AdminAge 		 { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string AdminID_card { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public string Admin_Roles { get; set; }
    }
}
