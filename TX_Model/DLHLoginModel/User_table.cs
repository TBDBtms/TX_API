using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Total_Auto_Model.DLHLoginModel
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class User_table
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int UserId 			 { get; set; }
        
        /// <summary>
        /// 手机号
        /// </summary>
        public string UserPhone 	 { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName		 { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd      { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool UserAge			 { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string UserID_card { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string User_Avatar { get; set; }
    }
}
