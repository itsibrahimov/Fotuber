using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFreamework;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EfServiceDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>(); 
            
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();
            
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IExcelService, ExcelManager>();


            //services.AddScoped<IContactUsService, ContactUsManager>();
            //services.AddScoped<IContactUsDal, EfContactUsDal>();

            //services.AddScoped<IAnnouncementService, AnnouncementManager>();
            //services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            //services.AddScoped<IAccountService, AccountManager>();
            //services.AddScoped<IAccountDal, EfAccountDal>();

            //services.AddScoped<IUowDal, UowDal>();
        }

        //    public static void CustomerValidator(this IServiceCollection services)
        //    {
        //        services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
        //    }
        //}
    }
}
