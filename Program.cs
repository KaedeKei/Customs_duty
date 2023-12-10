using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/customs_duty", (double price) => "������ ������� ��� ������� ����� " + price + "�: " + Duty(price) + "�");

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