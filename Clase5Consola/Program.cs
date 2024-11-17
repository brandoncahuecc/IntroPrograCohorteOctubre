
using Clase5Consola.Iterancion;

Console.WriteLine("Ciclo For");
Ciclo ciclo = new();
ciclo.CicloFor();

Console.WriteLine("________________________________");
Console.WriteLine("Ingrese hasta que número imprimir");
string numeroInput = Console.ReadLine();

//int numero = 10;
int.TryParse(numeroInput, out int numero);

ciclo.CicloFor(numero);


Console.WriteLine("________________________________");
Console.WriteLine("Ciclo While");

bool esTrue = false;

ciclo.CicloWhile();
ciclo.CicloWhile(esTrue);


Console.WriteLine("________________________________");
Console.WriteLine("Ciclo Do While");

ciclo.CicloDoWhile();
ciclo.CicloDoWhile(esTrue);


//esTrue = false;


Console.WriteLine("________________________________");
Console.WriteLine("Arreglos");
string[] cadenas = ciclo.ObtenerArreglo();

Console.WriteLine("For");
ciclo.ImprimirArregloFor(cadenas);

Console.WriteLine("Foreach");
ciclo.ImprimirArregloForeach(cadenas);


Console.WriteLine("________________________________");
Console.WriteLine("Listas");
List<string> nombres = ciclo.ObtenerLista();

Console.WriteLine("Foreach");
ciclo.ImprimirListaForeach(nombres);

nombres.Add("Tomas");
nombres.Add("David");

Console.WriteLine("ForEach");
ciclo.ImprimirListaForEach(nombres);

Console.WriteLine("________________________________");
Console.WriteLine("Tipo de Parámetros");

Console.WriteLine("********************************");
Console.WriteLine("Antes de Ejecutar TipoParametros");
Console.WriteLine("********************************");
string valor = "Hola mundo";
string referencia = "Como estas";
//string salida = "Adios";
//string opcional = "Prueba";

Console.WriteLine($"Valor = {valor}");
Console.WriteLine($"Referencia = {referencia}");
//Console.WriteLine($"salida = {salida}");
//Console.WriteLine($"opciona = {opcional}");

ciclo.TipoParametros(valor, ref referencia, out string salida);

Console.WriteLine("********************************");
Console.WriteLine("Despues de Ejecutar TipoParametros");
Console.WriteLine("********************************");
Console.WriteLine($"Valor = {valor}");
Console.WriteLine($"Referencia = {referencia}");
Console.WriteLine($"salida = {salida}");
//Console.WriteLine($"opciona = {opcional}");

