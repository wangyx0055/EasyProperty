using EasyProperty.Common.Helper;
using EasyProperty.WebApp.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EasyProperty.WebApp.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        #region 展示登陆页面
        /// <summary>
        /// 展示登陆页面
        /// </summary>
        /// <returns></returns>
        [Route("Login")]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        } 
        #endregion

        #region 执行登陆
        /// <summary>
        /// 执行登陆
        /// </summary>
        /// <param name="model"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [Route("Login")]
        [HttpPost]
        public ActionResult Login(UserLoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                Entity.User user = new Entity.User();
                user = db.Users.Where(u => u.Username == model.UserName).SingleOrDefault();
                if (user == null)
                {
                    ModelState.AddModelError("", "该用户不存在请确认用户！");
                }
                else
                {
                    if (user.Password.Equals(Encryt.GetMD5(model.Password)))
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                        return Redirect("/Home/Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "密码输入错误，请重试！");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "你填写的登陆信息有错误");
            }
            return View(model);
        } 
        #endregion



    }
}