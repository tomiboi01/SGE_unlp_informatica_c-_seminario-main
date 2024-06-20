using SGE.Repositorios;
using SGE.Aplicacion;
using SGE.UI.Components;
var builder = WebApplication.CreateBuilder(args);
//

builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioSqlite>()
                .AddScoped<IExpedienteRepositorio, ExpedienteSqlite>()
                .AddScoped<ITramiteRepositorio, TramiteSqlite>()
                .AddTransient<CasoDeUsoExpedienteAlta>()
                .AddTransient<CasoDeUsoExpedienteBaja>()
                .AddTransient<CasoDeUsoExpedienteConsultaPorId>()
                .AddTransient<CasoDeUsoExpedienteConsultaTodos>()
                .AddTransient<CasoDeUsoExpedienteModificacion>()
                .AddTransient<CasoDeUsoTramiteAlta>()
                .AddTransient<CasoDeUsoTramiteBaja>()
                .AddTransient<CasoDeUsoTramiteConsultaPorEtiqueta>()
                .AddTransient<CasoDeUsoTramiteModificacion>()
                .AddTransient<CasoDeUsoTramiteConsultaId>()
                .AddTransient<CasoDeUsoUsuarioAlta>()
                .AddTransient<CasoDeUsoUsuarioBaja>()
                .AddTransient<CasoDeUsoUsuarioModificar>()
                .AddTransient<CasoDeUsoUsuarioObtenerPorId>()
                .AddTransient<CasoDeUsoUsuarioObtenerTodos>()
                .AddTransient<IEspecificacionCambioDeEstado, EspecificacionCambioDeEstado>()
                .AddTransient<IServicioAutorizacion, ServicioAutorizacion>()
                .AddTransient<ManejarLogin>();
;


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

SGESqlite.Inicializar();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();





