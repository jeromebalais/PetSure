using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PetSureExam.API.Autofac
{
    public class Bootstrapper
    {
        public static void Run()
        {
            //Configure AutoFac  
            AutoFacWebAPI.Initialize(GlobalConfiguration.Configuration);
        }
    }
}