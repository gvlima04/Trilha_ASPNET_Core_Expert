// O builder é responsável por fornecer os métodos de controle dos serviços e demais funcionalidades na configuração da App;
var builder = WebApplication.CreateBuilder(args);


//_-_-_-_-_-_-_-_-_-_-_ Método ConfigureServices() da antiga Startup.cs _-_-_-_-_-_-_-_-_-_-_
// Nesta area adicionamos serviços ao pipeline

// Essa é a nova forma de adicionar o MVC ao projeto. Não se usa mais services.AddMvc();
builder.Services.AddControllersWithViews();

// Essa linha precisa sempre ficar por último na configuração dos serviços
var app = builder.Build();
// _-_-_-_-_-_-_-_-_-_-_ _-_-_-_-_-_-_-_-_-_-_ _-_-_-_-_-_-_-_-_-_-_ _-_-_-_-_-_-_-_-_-_-_


//_-_-_-_-_-_-_-_-_-_-_ Método Configure() da antiga Startup.cs _-_-_-_-_-_-_-_-_-_-_
// Aqui se configura comportamentos do request dentro do pipeline

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


// Mapeamento das rotas. No caso de precisar mapear mais de uma rota duplique o código abaixo;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Essa linha precisa sempre ficar por último na configuração do request pipeline
app.Run();
// _-_-_-_-_-_-_-_-_-_-_ _-_-_-_-_-_-_-_-_-_-_ _-_-_-_-_-_-_-_-_-_-_ _-_-_-_-_-_-_-_-_-_-_
