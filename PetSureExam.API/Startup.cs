using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using PetSureExam.API.Providers;

[assembly: OwinStartup(typeof(PetSureExam.API.Startup))]

namespace PetSureExam.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
