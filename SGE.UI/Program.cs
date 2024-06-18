 using SGE.Repositorios;
 using SGE.Aplicacion;
using SGE.UI.Components;
using SGE.Aplicacion.Servicios;
var builder = WebApplication.CreateBuilder(args);
// acceder a la base de datos desde los servicios
// consultar devolver enumerable o lista en los repositorios
// Add services to the container.
// verificar persimos en el caso de uso o en el frontend
// verificar hay un usuario con el mismo nombre 
// tirar autorizacion y validacionexce1ption en casos de uso o sus respectivas clases?
// actualizar estado esta mal que el date time now este en el repositorio
//consultar caso alta
// usar servicio o caso de uso en el loggin
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

app.Run();





