
using Clase8Consola;

//Almacenamiento<Persona> almacenamientoPersona = new Almacenamiento<Persona>();

//almacenamientoPersona.Objeto = new Persona()
//{
//    Nombre = "Brandon",
//    Edad = 28,
//    Id = 1,
//};


//Console.WriteLine("Persona");
//Console.WriteLine("Nombre: " + almacenamientoPersona.Objeto.Nombre);
//Console.WriteLine("Id: " + almacenamientoPersona.Objeto.Id);
//Console.WriteLine("Edad: " + almacenamientoPersona.Objeto.Edad);

//Almacenamiento<Animal> almacenamientoAnimal = new Almacenamiento<Animal>();

//almacenamientoAnimal.Objeto = new Animal()
//{
//    Nombre = "Perro",
//    Id = 1,
//    Peso = 20,
//    Raza = "Raza Perro"
//};


//Console.WriteLine("Animal");
//Console.WriteLine("Nombre: " + almacenamientoAnimal.Objeto.Nombre);
//Console.WriteLine("Id: " + almacenamientoAnimal.Objeto.Id);
//Console.WriteLine("Peso: " + almacenamientoAnimal.Objeto.Peso);
//Console.WriteLine("Raza: " + almacenamientoAnimal.Objeto.Raza);


Almacenamiento2<Persona, Animal> almacenamiento = new Almacenamiento2<Persona, Animal>();

almacenamiento.ObjetoUno = new Persona(1, "BRANDON", 28);
almacenamiento.ObjetoDos = new Animal(1, "PERRO", "OTHER", 10);


Console.WriteLine(almacenamiento.ObjetoUno.ToString());
Console.WriteLine(almacenamiento.ObjetoDos.ToString());

