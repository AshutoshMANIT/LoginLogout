using LoginLogoutJWT.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace LoginLogoutJWT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            //        builder.Services.AddDbContext<UserDbContext>(option =>
            //option.UseSqlServer(builder.Configuration.GetConnectionString("Server=ASUS\\SQLEXPRESS06;Database=AuthJWt;Integrated Security=true;Encrypt=false")));
            var cst = builder.Configuration.GetConnectionString("MyDatabase");
            builder.Services.AddDbContext<UserDbContext>(options =>  options.UseSqlServer(cst));
                //ServerVersion.AutoDetect("MyDatabase")
                // new mysqlserverversion(new version(8, 0, 11))
                
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