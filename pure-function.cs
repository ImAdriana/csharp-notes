// No es una función pura porque si lo ejecuto hoy o mañana, sus resultados serán diferentes

Console.WriteLine(GetTomorrow());
DateTime GetTomorrow()
{
    return DateTime.Now.AddDays(1);
}

// Función pura, regresa los mismos elementos

DateTime date = new DateTime(2024,10,11);
Console.WriteLine(GetTomorrow(date));

DateTime GetTomorrow(DateTime data)
{
    return data.AddDays(1);
}
// ***********************************************

// No es una función pura, porque altera el elemento externo modificándolo también a mayúscula
var product = new Product()
{
    Name = "Eyeliner"
};

Console.WriteLine(ToUpper(product).Name); // EYELINER
Console.WriteLine(product.Name); // EYELINER ... Aquí lo altera

Product ToUpper(Product product)
{
    product.Name = product.Name.ToUpper();
    return product;
}

class Product()
{
    public string Name { get; set; }
}

// Función pura, no modifica el elemento externo
var product = new Product()
{
    Name = "Eyeliner"
};

Console.WriteLine(ToUpper(product).Name); // EYELINER
Console.WriteLine(product.Name); // Eyeliner

Product ToUpper(Product product)
{
    var product2 = new Product()
    {
        Name = product.Name.ToUpper()
    };
    return product2;
}

class Product()
{
    public string Name { get; set; }
}

// ***********************************************
