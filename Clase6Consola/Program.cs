
using Clase6Consola.Clases;
using Clase6Consola.CustomEx;

//int total = 0;

//try
//{
//	Console.WriteLine("Ingrese un número:");
//	string cadena = Console.ReadLine() ?? string.Empty;
//	int numero = Convert.ToInt32(cadena);

//    total  = numero * 2;
//}
//catch (Exception ex)
//{
//	Console.WriteLine("No se ha completado la instrucción\r\n" + ex.Message);
//}
//finally
//{
//    Console.WriteLine("________________________");
//    Console.WriteLine("Total: " + total);
//}

//try
//{
//    throw new MensajeException(100, "Mi excepción perzonalizada", "Desde MensajeException");
//	//throw new Exception("Excepción general");
//}
//catch (MensajeException ex)
//{
//    Console.WriteLine("Mensaje: " + ex.Message);
//    Console.WriteLine("Mensaje de Usuario: " + ex.MensajeUsuario);
//    Console.WriteLine("Codigo de Error: " + ex.CodigoError);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Error: " + ex.Message);
//}


//FiguraGeometrica circulo = new Circulo("Circulo", 5);
//FiguraGeometrica rectangulo = new Rectangulo("Rectangulo", 10, 5);
//FiguraGeometrica cuadrado = new Rectangulo("Cuadrado", 5, 5);
//FiguraGeometrica triangulo = new Triangulo("Triangulo", 10, 15);

//Console.WriteLine($"{circulo.Nombre} - Área: {circulo.CalcularArea()} - Perímetro: {circulo.CalcularPerimetro()}");
//Console.WriteLine($"{rectangulo.Nombre} - Área: {rectangulo.CalcularArea()} - Perímetro: {rectangulo.CalcularPerimetro()}");
//Console.WriteLine($"{cuadrado.Nombre} - Área: {cuadrado.CalcularArea()} - Perímetro: {cuadrado.CalcularPerimetro()}");
//Console.WriteLine($"{triangulo.Nombre} - Área: {triangulo.CalcularArea()} - Perímetro: {triangulo.CalcularPerimetro()}");


List<FiguraGeometrica> figuras = new List<FiguraGeometrica>()
{
    new Circulo("Circulo", 5),
    new Rectangulo("Rectangulo", 10, 5),
    new Rectangulo("Cuadrado", 5, 5),
    new Triangulo("Triangulo", 10, 15)
};

figuras.ForEach(item =>
{
    Console.WriteLine($"{item.Nombre} - Área: {item.CalcularArea()} - Perímetro: {item.CalcularPerimetro()}");
});


