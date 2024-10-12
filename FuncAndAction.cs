// Uso de Func
// Un método que recibo uno o más parámetros y retorna un valor

var show = Show;

Some(show, "Hello frank");
string Show(string message)
{
    return message.ToUpper();
}

// La función Some es de orden superior porque recibe funciones como parámetros
void Some(Func<string, string> func, string message)
{
    Console.WriteLine("Hace algo al inicio");
    Console.WriteLine(func(message));
    Console.WriteLine("Hace algo al final");
}

// ***********************************************************************
// Uso de Action
// Recibe uno o más parámetros y no retorna ningún valor. Utilizar Action para apuntar
// a un método que no retorna void

var show = Show;

Some(show, "Hello frank");
void Show(string message)
{
    Console.WriteLine(message);
}

// La función Some es de orden superior porque recibe funciones como parámetros
void Some(Action<string> func, string message)
{
    Console.WriteLine("Hace algo al inicio");
    func(message);
    Console.WriteLine("Hace algo al final");
}

