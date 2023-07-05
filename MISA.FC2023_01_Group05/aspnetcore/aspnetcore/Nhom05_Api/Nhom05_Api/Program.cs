using Microsoft.AspNetCore.Mvc;
using Nhom05_Core.Exceptions;
using Nhom05_Core.Interfaces.Infrastructures;
using Nhom05_Core.Interfaces.Services;
using Nhom05_Core.Middlewares;
using Nhom05_Core.Resources;
using Nhom05_Core.Services;
using Nhom05_Infrastructure.Repository;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

// validate dữ liệu 
builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = actioncontext =>
    {
        var modelstate = actioncontext.ModelState;
        var errors = new Dictionary<string, string>();

        foreach (var entry in modelstate)
        {
            var key = entry.Key;
            var valueerrors = entry.Value.Errors.Select(error => error.ErrorMessage);
            var errormessage = string.Join(", ", valueerrors);

            errors[key] = errormessage;
        }

        return new BadRequestObjectResult(new BaseException
        {
            ErrorCode = (int)HttpStatusCode.BadRequest,
            DevMessage = ResourceVN.Validate_User_Input_Error,
            UserMessage = ResourceVN.Validate_User_Input_Error,
            TraceId = "",
            MoreInfo = "",
            Data = errors
        });
    };
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Sử dụng thư viện AutoMapter để chuyển đổi giữa các đối tượng dữ liệu
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Policy
builder.Services.AddCors();

// Tiêm DI
builder.Services.AddScoped<IThreadRepository, ThreadRepository>();
builder.Services.AddScoped<IThreadService, ThreadService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();

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

// Middleware
app.UseMiddleware<ExceptionMiddleware>();

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});

app.Run();
