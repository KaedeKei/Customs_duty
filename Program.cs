using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/customs_duty", (double price) => "размер пошлины дл€ посылки ценой " + price + "И: " + Duty(price) + "И");

app.Run();

double Duty(double price)
{
    if (price <= 200)
    {
        return 0;
    }

    else
    {
        return (price-200)*0.15;
    }
}