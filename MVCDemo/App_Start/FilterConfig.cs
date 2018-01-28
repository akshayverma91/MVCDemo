﻿using System.Web;
using System.Web.Mvc;

namespace MVCDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); //Old Line
            filters.Add(new AuthorizeAttribute()); //New Line
        }
    }
}
