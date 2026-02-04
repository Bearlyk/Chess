using System.IO;
 leer();
//write();

 static void write()

{
    string ruta = @"c:\my_chess_program\table3.txt";
    string myname = "Anthony Jhorel Inca Figueroa";
    File.WriteAllText(ruta, myname);
}

static void leer()
{
 string contenido = File.ReadAllText("table.txt");


Console.WriteLine(contenido);


Console.ReadKey(); 
   
}
