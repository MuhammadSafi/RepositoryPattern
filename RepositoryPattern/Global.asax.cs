using Autofac;
using Autofac.Integration.Mvc;
using RepositoryPattern.DAL;
using RepositoryPattern.DAL.Repositories;
using RepositoryPattern.DAL.Services;
using RepositoryPattern.Repositories.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RepositoryPattern
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<EmployeeRepository>().As<Repository<IEmployeeRepository>>();
           // builder.RegisterType<EmployeeRepository>().As<Repository<Employee>>();



            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));




            // builder.RegisterType<EmailService>().As<IMailService>();
          //  var container = builder.Build();

            container.Resolve<IEmployeeService>();
            container.Resolve<IEmployeeRepository>();


          
        }


    }
}
