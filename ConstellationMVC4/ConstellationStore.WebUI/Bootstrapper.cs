using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using ConstellationStore.Contracts.Repositories;
using ConstellationStore.Models;

namespace ConstellationStore.WebUI
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();            
            container.RegisterType<IRepositoryBase<Customer>, CustomerRepository>();
            container.RegisterType<IRepositoryBase<Product>, ProductRepository>();
            container.RegisterType<IRepositoryBase<Order>, OrderRepository>();
            container.RegisterType<IRepositoryBase<Basket>, BasketRepository>();
            container.RegisterType<IRepositoryBase<BasketItem>, BasketItemRepository>();

            return container;
        }
    }
}