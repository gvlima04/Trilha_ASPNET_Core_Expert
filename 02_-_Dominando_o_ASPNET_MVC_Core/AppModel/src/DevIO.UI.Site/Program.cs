// Builder que será o meio de acesso de todos os recursos
var builder = WebApplication.CreateBuilder(args);

// Método ConfigureServices adicionando o MVC
builder.Services.AddControllersWithViews();

// Construção da APP
var app = builder.Build();

// Ativando a pagina de erros caso seja ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Adicionando Rota padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
