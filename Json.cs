using System.Text.Json;

// Asignar sin necesidad de un constructor
var adri = new People()
{
    Name = "Adriana",
    Age = 22,
};

string json = JsonSerializer.Serialize(adri);
Console.WriteLine(json);

string jsonInformation = @"{
    ""Name"":""Adriana"",
    ""Age"":22
}";

// ? Indica que podría ser Null
People? juan = JsonSerializer.Deserialize<People>(jsonInformation);
Console.WriteLine(juan?.Name);
Console.WriteLine(juan?.Age);

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}
