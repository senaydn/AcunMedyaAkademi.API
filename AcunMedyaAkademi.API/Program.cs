var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Kullanıcının yaşını alarak ehliyet alıp alamayacağını kontrol eder.
app.MapGet("/CheckAgeValidation", (int age) =>
    {
        if (age >= 18)
        {
            return Task.FromResult("Ehliyet alabilirsiniz.");
        }
        else
        {
            return Task.FromResult("Ehliyet alamazsınız.");
        }
    })
    .WithName("CheckAgeValidation")
    .WithOpenApi();

// Masaüstünde "ageInfo.txt" adında bir dosya oluşturur ve yaşı içerisinden okuyarak döner.
app.MapPost("/CheckAgeFromDirectory", async (int age) =>
{
    var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ageInfo.txt");

    // Dosyaya yazma işlemi
    await File.WriteAllTextAsync(filePath, age.ToString());

    // Dosyadan okuma işlemi
    string fileContent = await File.ReadAllTextAsync(filePath);

    // Yaşı kontrol etme
    if (int.TryParse(fileContent, out int storedAge))
    {
        if (storedAge >= 18)
        {
            return Results.Content("Ehliyet alabilirsiniz.");
        }
        else
        {
            return Results.Content("Ehliyet alamazsınız.");
        }
    }

    return Results.BadRequest("Geçerli bir yaş değeri okunamadı.");
});

app.Run();
