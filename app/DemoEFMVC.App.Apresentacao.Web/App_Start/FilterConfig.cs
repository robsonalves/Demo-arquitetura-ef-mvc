﻿using System.Web;
using System.Web.Mvc;

namespace DemoEFMVC.App.Apresentacao.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
