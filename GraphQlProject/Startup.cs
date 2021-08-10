using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQLCoffee.Data;
using GraphQLCoffee.Interfaces;
using GraphQLCoffee.Mutation;
using GraphQLCoffee.Query;
using GraphQLCoffee.Schema;
using GraphQLCoffee.Services;
using GraphQLCoffee.Type;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQlProject
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
            services.AddControllers();
            services.AddTransient<IMenu, MenuService>();
            services.AddTransient<ISubMenu, SubMenuService>();
            services.AddTransient<IReservation, ReservationService>();
            services.AddTransient<MenuType>();
            services.AddTransient<ReservationType>();
            services.AddTransient<SubMenuType>();
            services.AddTransient<MenuQuery>();
            services.AddTransient<ReservationQuery>();
            services.AddTransient<SubMenuQuery>();
            services.AddTransient<RootQuery>();
            services.AddTransient<ISchema, RootSchema>();
            services.AddTransient<MenuMutation>();
            services.AddTransient<ReservationMutation>();
            services.AddTransient<SubMenuMutation>();
            services.AddTransient<RootMutation>();
            services.AddTransient<MenuInputType>();
            services.AddTransient<ReservationInputType>();
            services.AddTransient<SubMenuInputType>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();

            services.AddDbContext<GraphQLDbContext>(option => option.UseSqlServer(@"Data Source= (localdb)\MSSQLLocalDB;Initial Catalog=GraphQLCoffee;Integrated Security = True"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, GraphQLDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            dbContext.Database.EnsureCreated();
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();
        }
    }
}
