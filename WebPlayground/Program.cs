var builder = WebApplication.CreateBuilder(args);

// 添加服务
builder.Services.AddOpenApi(); // 启用 OpenAPI 支持
builder.Services.AddControllers(); // 注册控制器服务

// 配置 Log4Net
builder.Logging.ClearProviders(); // 可选：清除默认日志提供程序
builder.Logging.AddLog4Net("log4net.config"); // 指定配置文件路径

var app = builder.Build();

// 配置 HTTP 请求管道
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers(); // 映射控制器路由

app.UseSwaggerUI((options) =>
{
    options.SwaggerEndpoint("/openapi/v1.json", "OpenAPI V1");
});

app.Run();