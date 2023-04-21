using Microsoft.EntityFrameworkCore;
using Recruiting.Infrastructure.Data;
using HrmRecruitingProj.Utility;
using Recruiting.ApplicationCore.Contracts.Repositories;
using Recruiting.Infrastructure.Repositories;
using Recruiting.ApplicationCore.Contracts.Services;
using Recruiting.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICandidateRepository,CandidateRepository>();
builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<IJobRequirementRepository, JobRequirementRepository>();
builder.Services.AddScoped<IJobRequirementService, JobRequirementService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RecruitingDbContext>(option => {
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    option.UseSqlServer(builder.Configuration.GetConnectionString("RecruitingDbContext"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseMiddlewareExtension();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
