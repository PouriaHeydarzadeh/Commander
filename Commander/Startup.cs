using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Commander
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.

		//***************************************************************************
		//	// My Notes : 
		//	// we use following method for adding "services" Or "(DI)Dependency Injection"
		//***************************************************************************

		//public void ConfigureServices(IServiceCollection services)
		//{
		//// Old solution (ASP.NET Core 2.2) :
		//// services.AddMVC();

		//	// (1)Only for using controller - API :
		//	//services.AddControllers();

		//	//(2)for using controller - API - views :
		//	// services.AddControllersWithViews();

		//	//(3)for using Razor Pages : 
		//	// services.AddRazorPages();

		//	//(4) for using controller - API - Views - Razor Pages : 
		//	// services.AddControllersWithViews();
		//	// services.AddRazorPages();

		//	// My Notes :
		//	//*** Automatic Dependency Injection:

		//	//ServicesCollection Lifetimes:

		//	//1) AddSingleton
		//	//		Same for every request
		//	//2) AddScoped
		//	//		Created once for per client request
		//	//3) AddTransient
		//	//		New instance created every time


		//	services.AddTransient<Data.ICommandRepository, Data.CommandRepository>();
		//}

		public void ConfigureServices(IServiceCollection services)
		{
			
			//	//For Using option.UseSqlServer --> using Microsoft.EntityFrameworkCore; 
			//	//Note : AddDbContext is equal with AddTransient, but its only for DatabaseContext!
		

			services.AddDbContext<Data.DatabaseContext>(option =>
			{
				option.UseSqlServer(Configuration.GetConnectionString("CommanderConnectionString"));
			});

			services.AddControllers();

			//ServicesCollection Lifetimes:
			//1) AddSingleton
			//		Same for every request
			//2) AddScoped
			//		Created once for per client request
			//3) AddTransient
			//		New instance created every time

			services.AddTransient<Data.ICommandRepository, Data.CommandRepository>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

		//***************************************************************************
		//My Notes : 
		//we use following method for using Or adding "Midle Wares"
		//***************************************************************************
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			//Old solution (ASP.NET Core 2.2) :
			// app.UseMvc();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseAuthorization();
			
			app.UseEndpoints(endpoints =>
			{
				
				endpoints.MapControllers();
			});

			//(1)
			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapControllers();
			//});

			//(2)
			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapControllerRoute(
			//name : "default",
			//pattern : "{controller=Home}/{action=Index}/{Id?}" );
			//});

			//(3)
			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapRazorPages();
			//});

			//(4)
			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapControllerRoute(
			//name : "default",
			//pattern : "{controller=Home}/{action=Index}/{Id?}" );

			//	endpoints.MapRazorPages();
			//	
			//});
		}
	}
}
