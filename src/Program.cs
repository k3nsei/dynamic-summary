using DynamicSummary;

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

app.MapGet("/summary", () =>
    {
        return new RootNodeBuilder(
            new[]
            {
                new SectionNodeBuilder(new SectionNodeProps("Person"), new[]
                {
                    new TextNodeBuilderBuilder(new TextNodeProps { ID = "name", Label = "Name" }, "Jan").Build(),
                    new TextNodeBuilderBuilder(new TextNodeProps { ID = "surname", Label = "Surname" }, "Kowalski")
                        .Build(),
                    new DateNodeBuilder(new DateNodeProps { ID = "birth-date", Label = "Birthday" },
                        new DateTime(1985, 6, 30, 0, 0, 0, DateTimeKind.Utc)).Build(),
                    new CurrencyNodeBuilder(new CurrencyNodeProps { ID = "account-balance", Label = "Account Balance" },
                            new Currency("EUR", 15000m))
                        .Build()
                }).Build(),
            }
        ).Build();
    })
    .WithName("DynamicSummary")
    .WithOpenApi();

app.Run();