 using SGE.Repositorios;
 using SGE.Aplicacion;
using SGE.UI.Components;
using SGE.Aplicacion.Servicios;
using SGE.UI.Components.Pages;
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
                .AddTransient<CasoDeUsoUsuarioAlta>()
                .AddTransient<CasoDeUsoUsuarioBaja>()
                .AddTransient<CasoDeUsoUsuarioObtenerPorId>()
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

Expediente e = new Expediente("asdf");
CasoDeUsoExpedienteAlta c = new CasoDeUsoExpedienteAlta(new ExpedienteSqlite(), new ServicioAutorizacion(new UsuarioSqlite()));
c.Ejecutar(1,e);


app.Run();





