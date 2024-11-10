
string mensaje = "Hola, Bienvenidos al curso de Intro a Progra C#";
Console.WriteLine(mensaje);

int posicion = mensaje.IndexOf("enidos");

if (posicion != -1)
{
    Console.WriteLine("Posición de texto enidos: " + posicion);
}
else
{
    Console.WriteLine("enidos no se encuentra dentro del texto");
}


//posicion = mensaje.IndexOf("enidoss");
//Console.WriteLine("Posición de texto enidoss: " + posicion);

posicion = mensaje.IndexOf("e");
Console.WriteLine("La primera letra e se encuentra en la posición: " + posicion);

posicion = mensaje.LastIndexOf("o");
Console.WriteLine("La ultima letra o se encuentra en la posición: " + posicion);

int posicionInicial = mensaje.IndexOf("Progra");
int posicionFinal = mensaje.LastIndexOf("Progra");

Console.WriteLine(posicionInicial + " - " + posicionFinal);

string temporal = mensaje.Remove(posicionInicial, 6);
Console.WriteLine("Mensaje sin la palabra Progra: " + System.Environment.NewLine + temporal);

Console.WriteLine("Mensaje separado por -");
string mensajeSinEspacios = mensaje.Replace(" ", "-");
Console.WriteLine(mensajeSinEspacios);

