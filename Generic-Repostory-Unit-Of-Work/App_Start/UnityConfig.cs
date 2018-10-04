using Business.UserServices;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Generic_Repostory_Unit_Of_Work
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            container.RegisterType<IUserService, UserService>();

        }
    }
}