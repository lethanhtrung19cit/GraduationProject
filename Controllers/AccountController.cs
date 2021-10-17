using GraduationProject.Models.DAO;
using GraduationProject.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GraduationProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        FurnitureEntities furnitureEntities = new FurnitureEntities();

 
        public ActionResult Login()
        {
            Session.Clear();
            Session.RemoveAll();
            FormsAuthentication.SignOut();
            Session["Role"] = "null";
            Session["Email"] = "null";
             return View();
        }
        public ActionResult LoginPost(Account account, string returnURL = "")
        {

            var obj = furnitureEntities.Accounts.Where(a => a.Email.Equals(account.Email) && a.PassWord.Equals(account.PassWord) && a.Role == account.Role).FirstOrDefault();
            if (obj != null)
            {
                Session["Role"] = obj.Role.ToString();
                Session["Email"] = obj.Email.ToString();
                ConstantSession.Email = obj.Email;
                Session.Add(ConstantSession.Email, obj);
                FormsAuthentication.SetAuthCookie(account.Email, false);
                if (Url.IsLocalUrl(returnURL) && returnURL.Length > 1 && returnURL.StartsWith("/") && returnURL.StartsWith("//") && returnURL.StartsWith("/\\"))
                {
                    return Redirect(returnURL);
                }
                if (Session["Role"].Equals("1"))
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (Session["Role"].Equals("0"))
                {
                    return RedirectToAction("Index", "Admin");
                }
                

            }


            ModelState.AddModelError("SessionLogin", "Tên đăng nhập hoặc mật khẩu không đúng");
            return View("Login");
        }

    }

     
}