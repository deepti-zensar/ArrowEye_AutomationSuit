﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Configuration;


namespace ArrowEye_ClientPortal_Automation.Common
{
     public static class AppNameHelper
     {
        static public string appBaseURL
        {
            get
            {
                return ConfigurationManager.AppSettings["Environment"];
            }
        }





     }
}