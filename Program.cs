using CsBases.Fundamentals;
using static System.Console;
class Program
{
    static void Main()
    {
        var laptop=new Product("Laptop",1200);
        WriteLine(laptop.GetDescription());
        var soporte=new ServiceProduct("Soporte técnico",300,30);
        WriteLine(soporte.GetDescription());
    
        var product=new Product("Mouse Gamer",300);
        var prodcutDto= ProductAdapter.ToDto(product);
        WriteLine($"{prodcutDto.Name} - {prodcutDto.Price} - Código: {prodcutDto.Code}");
        WriteLine($"hola");
    }
}
    