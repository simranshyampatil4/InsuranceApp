using InsuranceApp.Data;
using InsuranceApp.Repository;
using InsuranceApp.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace InsuranceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddControllers().AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
            builder.Services.AddTransient(typeof(IEntityRepository<>), typeof(EntityRepository<>));
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<IRoleService, RoleService>();
            builder.Services.AddTransient<IInsurancePlanService, InsurancePlanService>();
            builder.Services.AddTransient<IInsuranceSchemeService, InsuranceSchemeService>();
            builder.Services.AddTransient<ISchemeDetailsService, SchemeDetailsService>();
            builder.Services.AddTransient<IInsurancePolicyService, InsurancePolicyService>();

            builder.Services.AddDbContext<MyContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("connString"));
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}