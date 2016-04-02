[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(LGroup.MVC.Presentation.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(LGroup.MVC.Presentation.App_Start.NinjectWebCommon), "Stop")]

namespace LGroup.MVC.Presentation.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    //nossas dlls
    using LGroup.MVC.Business;
    using LGroup.MVC.Business.Base;
    using LGroup.MVC.DataAccessLayer;
    using LGroup.MVC.DataAccessLayer.Base;
    using DataTransferObject;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //onde encontrar qualquer amigo Business, inicialize ele

            kernel.Bind<IBaseBusiness<AmigoDTO>>().To<AmigoBusiness>();
            kernel.Bind<IBaseDAO<AmigoDTO>>().To<AmigoDAO>();


        }        
    }
}
