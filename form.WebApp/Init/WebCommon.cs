using form.Common;
using form.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace form.WebApp.Init
{
    public class WebCommon : ICommon
    {
        public string GetUSerName()
        {
            if(HttpContext.Current.Session["login"]!=null)
            {
                formUser user = HttpContext.Current.Session["login"] as formUser;
                return user.ad;
            }
            return null;
        }
    }
}