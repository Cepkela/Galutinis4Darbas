﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace Darbbas4
{
    public class Cash : ActionFilterAttribute
    {
        public int Duration { get; set; }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue
            {
                MaxAge = TimeSpan.FromSeconds(Duration),
                MustRevalidate = true,
                NoStore = true,
                Public = true,
                NoTransform = false
            }; 
        }
    }
}