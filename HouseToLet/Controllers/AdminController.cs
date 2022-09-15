using HouseToLet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HouseToLet.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        ToLetModel db = new ToLetModel();
        public ActionResult Signup(int id =0)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User ToLetModel)
        {
            ToLetModel db = new ToLetModel();
            if (db.Users.Any(x => x.UserId == ToLetModel.UserId))
            {
                ViewBag.Notification = "This Username has already existed";
                return View();
            }
            else
            {
                using (ToLetModel dbModel = new ToLetModel())
                {
                    dbModel.Users.Add(ToLetModel);
                    dbModel.SaveChanges();

                }
                ModelState.Clear();
                ViewBag.SuccessMessage = "Registration Success";
                return View();
            }
        }

        [HttpGet]
        public ActionResult signin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signin(HouseToLet.Models.User ToLetModel)
        {
            var checkLogin = db.Users.Where(x => x.UserId.Equals(ToLetModel.UserId) && x.Password.Equals(ToLetModel.Password)).FirstOrDefault();
            if (checkLogin != null)
            {
                FormsAuthentication.SetAuthCookie(ToLetModel.UserId, false);
                //Session["IdUsSS"] = For.IdUs.ToString();
                Session["UserId"] = ToLetModel.UserId.ToString();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Notification1 = "Wrong Username or password";
            }

            return View();
        }
    }
}