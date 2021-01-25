using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Total_Auto_Model.DLHLoginModel;


namespace Total_Auto_DAL.DLH_User_DAL
{
    public class DLH_User
    {
        public User_table LoginUser(string UserPhone="",string Userpwd="")
        {
            string sql = $"select * from User_table where UserPhone='{UserPhone}' AND UserPwd='{Userpwd}'";
            var model =  DLH_DBHelper.GetList<User_table>(sql).FirstOrDefault();
            return model;
            
        }


        public int AddUser(User_table u)
        {
            var Pwd = u.UserPwd;

            var UserPwd = MD5Helper.MD5(Pwd);
           
            string sql = $"INSERT INTO User_table VALUES(NULL,'{u.UserPhone}', '{u.UserName}','{UserPwd}',{u.UserAge},'{u.UserID_card}','{u.User_Avatar}')";

            return DLH_DBHelper.CMD(sql);
        }
    }
}
