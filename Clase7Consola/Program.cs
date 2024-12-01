using Clase7Consola.Clases;

CrearDestruirPersonajes();

GC.Collect();
GC.WaitForPendingFinalizers();



static void CrearDestruirPersonajes()
{
    Mario mario = new Mario();

    //mario.RestarVida();
    //mario.SumarVida();
    mario.Mover();
    mario.UsarHabilidadEspecial();
    mario = null;


    Luigi luigi = new Luigi("Luigi", "M", 3);

    //luigi.SumarVida();
    //luigi.RestarVida();
    luigi.Mover();
    luigi.UsarHabilidadEspecial();
    luigi = null;


    Peach peach = new Peach();

    //peach.SumarVida();
    //peach.RestarVida();
    peach.Mover();
    peach = null;


    Browser browser = new Browser();

    browser.Mover();
    browser = null;
}