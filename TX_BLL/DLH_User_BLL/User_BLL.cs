using System;
using System.Collections.Generic;
using System.Text;
using Total_Auto_Model.DLHLoginModel;
using Total_Auto_DAL.DLH_User_DAL;

namespace Total_Auto_BLL.DLH_User_BLL
{
    public class User_BLL
    {
        DLH_User Udal = new DLH_User();
        public User_table LoginUser(string UserPhone="", string Userpwd="")
        {
            return Udal.LoginUser(UserPhone, Userpwd);
        }
        public int AddUser(User_table u)
        {
            return Udal.AddUser(u);
        }
    }
}
