using DetRigtigeSemesterProjekt.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// (Thomas) Her fort�ller vi builderne at den skal anvende "AddSingleton", som kun skaber 1 instance af klassen "HoldService" 
// (Som kan deles af alle de klasser vi har lavet dependency Injection) 
builder.Services.AddSingleton<IHoldService, HoldService>();
builder.Services.AddTransient<JsonFileHoldService>();
//builder.Services.AddSingleton<ITr�nerService, Tr�nerService>();
//builder.Services.AddTransient<JsonFileTr�nerService>();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
