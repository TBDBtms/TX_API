using System;
using System.Collections.Generic;
using System.Linq;
using Total_Auto_BLL.DLH_User_BLL;
using Total_Auto_Model.DLHLoginModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Total_Auto_API.Controllers
{

    [ApiController]
    public class Total_Auto_DLHController : ControllerBase
    {
        User_BLL Ubll = new User_BLL();
        [Route("api/[Controller]/GitUserLogin")]
        [HttpGet]
        public IActionResult GitUserLogin(string UserPhone="",string UserPwd="")
        {
            var model =Ubll.LoginUser(UserPhone,UserPwd);
            return Ok(model);
        }


        [Route("api/[Controller]/AddUser")]
        [HttpPost]
        public IActionResult AddUser([FromForm]User_table u)
        {       

            return  Ok(Ubll.AddUser(u));
        }


        [Route("api/[Controller]/UserGetPhone")]
        [HttpPost]
        public string UserGetPhone(string phone)
        {
            Random re = new Random();
            string vit = re.Next(10000, 99999).ToString();

            string tem = Convert.ToString(3152);

            var client = new ZhenziSmsClient("https://sms_developer.zhenzikj.com", "107770", "031e177b-9401-4a05-baa7-39aff77154c9");

            var parameters = new Dictionary<string, Object>();
            parameters.Add("number",phone);
            parameters.Add("templateId",tem);
            var templateParams = new string[2];
            templateParams[0] = vit;
            templateParams[1] = "5分钟";
            parameters.Add("templateParams", templateParams);
            //parameters.Add("clientIp", "792.168.2.222");
            //parameters.Add("messageId", "");
            var result = client.Send(parameters);
            return result;
        }
    }
}
