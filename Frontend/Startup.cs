using Repository;
using Frontend.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using MongoDB.Driver;
using Repository.Interfaces;
using Service.Interfaces;
using Service;


namespace Frontend
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			//var databaseName = Configuration.GetSection("ConnectionStrings")["DatabaseName"];
			//var connectionString = Configuration.GetSection("ConnectionStrings")["ConnectionString"];
			
			services.AddDbContext<AppDBContext>(options => options
			.UseSqlServer(Configuration.GetConnectionString("AppConnectionString")));

			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddTransient<IUserService, UserService>();

			services.AddControllersWithViews();
			services.AddScoped<IViewRender, ViewRender>();

			//services.AddSingleton<IMongoClient, MongoClient>(provider => new MongoClient(connectionString));

			//services.AddSingleton(provider =>
			//{
			//	var service = (IMongoClient)provider.GetService(typeof(IMongoClient));
			//	return service.GetDatabase(databaseName);
			//});

			//services.AddScoped<IUserRepository, UserRepository>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
