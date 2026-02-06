using System.IO;

write();
leer();

static void write()
{
    string ruta = @"c:\my_chess_program\table3.txt";
    string myname = "Anthony Jhorel Inca Figueroa";
    File.WriteAllText(ruta, myname);
}
static void leer()
{
   
    string rutaArchivo = @"C:\my_chess_program\table.txt";

    string contenidoUltimaVez = "";

    Console.WriteLine("--- Esperando cambios en el archivo ---");

    while (true)
    {
        if (File.Exists(rutaArchivo))
        {
            string contenidoActual = File.ReadAllText(rutaArchivo);

            if (contenidoActual != contenidoUltimaVez)
            {
                Console.Clear();
                Console.WriteLine("¡El archivo se actualizó!");
                Console.WriteLine("--------------------------");
                Console.WriteLine(contenidoActual);

                contenidoUltimaVez = contenidoActual;
            }
        }
        else
        {
            Console.WriteLine("No encuentro el archivo 'datos.txt'...");
        }
        Thread.Sleep(1000);
    }
}
