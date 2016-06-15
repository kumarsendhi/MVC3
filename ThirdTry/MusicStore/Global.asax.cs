using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using MusicStore.Models;

namespace MusicStore
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            Database.SetInitializer<MusicStoreDataContext>(new MusicStoreDataContextInitializaer());
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        public class MusicStoreDataContextInitializaer : DropCreateDatabaseIfModelChanges<MusicStoreDataContext>
        {
            protected override void Seed(MusicStoreDataContext context)
            {
                base.Seed(context);
                context.Artists.Add(new Artist
                {
                    ArtistID = 1,
                    ArtistName = "Seyon"
                });
                context.Artists.Add(new Artist
                {
                    ArtistID = 2,
                    ArtistName = "Kumar"
                });
                context.Artists.Add(new Artist
                {
                    ArtistID = 3,
                    ArtistName = "Kamal"
                });

                context.SaveChanges();
            }
        }
    }
}