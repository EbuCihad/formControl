using form.BusinessLayer;
using form.Entities;
using form.Entities.ValueObject;
using form.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace form.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           
            myFormViewModel mfvm = new myFormViewModel();
            indexshake ish = new indexshake();
            myFormManager mfm = new myFormManager();

            ish.myformmanager = mfm;
            ish.myfromviewmodel = mfvm;
            if(Session["login"]!=null)
            {
                return View(ish);
            }
            return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult Index(indexshake model)
        {
            
            myFormViewModel myf = model.myfromviewmodel;
            myf.createdBy = Int32.Parse(Session["adminId"].ToString());
             formManager fm = new formManager();

            fm.RegisterMyForm(myf);
            myFormViewModel mfvm = new myFormViewModel();
            indexshake ish = new indexshake();
            myFormManager mfm = new myFormManager();

            ish.myformmanager = mfm;
            ish.myfromviewmodel = mfvm;
            return View(ish);
        }
        public ActionResult Select(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            myFormManager mfm = new myFormManager();
            myform mf = mfm.getMyFormById(id.Value);
            if(mf==null)
            {
                return HttpNotFound();
            }
            return View(mf);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            formUserManager fum = new formUserManager();
            BusinessLayerResult<formUser> res = fum.loginUser(model);

            if(res.Errors.Count>0)
            {
                res.Errors.ForEach(x => ModelState.AddModelError("", x));
                return View(model);
            }
            Session["login"] = res.Result;
            Session["adminId"]=res.Result.id;

            return RedirectToAction("Index");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                formUserManager fum = new formUserManager();
                BusinessLayerResult<formUser> res = fum.RegisterUser(model);
                if(res.Errors.Count>0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x));
                    return View(model);
                }
                //formUser user = null;
                //try
                //{
                //    user=fum.RegisterUser(model);
                //}
                //catch(Exception ex)
                //{
                //    ModelState.AddModelError("", ex.Message);
                //}
                //    foreach(var item in ModelState)
                //    {
                //        if(item.Value.Errors.Count>0)
                //        {
                //            return View(model);
                //        }
                //    }

                //if (user == null)
                //{
                //    return View(model);
                //}
                return RedirectToAction("RegisterOk");
            }

            return View(model);
        }

        public ActionResult RegisterOk()
        {
            return View();
        }



    }
}