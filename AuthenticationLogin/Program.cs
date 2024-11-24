using AuthenticationLogin.Data;
using AuthenticationLogin.Data.Interface;
using AuthenticationLogin.Data.Interface.IContactUs;
using AuthenticationLogin.Data.Interface.IFeedback;
using AuthenticationLogin.Data.Interface.IJobSeeker;
using AuthenticationLogin.Data.Interface.INewCompany;
using AuthenticationLogin.Data.Repositorys;
using AuthenticationLogin.Data.Repositorys.ContactUsRepository;
using AuthenticationLogin.Data.Repositorys.FeedbackRepository;
using AuthenticationLogin.Data.Repositorys.JobSeekerRepository;
using AuthenticationLogin.Data.Repositorys.NewCompanyRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
   .AddJwtBearer(options =>
   {
       options.TokenValidationParameters = new TokenValidationParameters
       {
           ValidateIssuer = true,
           ValidateAudience = true,
           ValidateLifetime = true,
           ValidateIssuerSigningKey = true,
           ValidIssuer = builder.Configuration["Jwt:Issuer"],
           ValidAudience = builder.Configuration["Jwt:Audience"],
           IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
       };
   });


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUser,UserRepository>();
builder.Services.AddScoped<IRole,RoleRepository>();
builder.Services.AddScoped<IUserRole,UserRoleRepository>();
//Jobseeker.......
builder.Services.AddScoped<IMyAccount,MyAccountRepository>();

//New Company.....
builder.Services.AddScoped<INCMyAccount,NCMyAccountRepository>();
builder.Services.AddScoped<IPostNewJob,NewJobRepository>();

//FeedBack......
builder.Services.AddScoped<IFeedback,FeedbackRepository>();

//Contact Us.......
builder.Services.AddScoped<IContactUs,ContactUsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();
