﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using PetSureExam.Service.Implementation;
using PetSureExam.Service.Interface;

using PetSureExam.Repository.Interface;


namespace PetSureExam.API.Autofac
{
    public class AutoFacWebAPI
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<CustomerService>()
                .As<ICustomerService>()
                .InstancePerRequest();

            builder.RegisterType<Repository.Implementation.Repository>()
                .As<IRepository>()
                .InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }

    }
}