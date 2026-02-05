using System.IO;
write();
static void write()
{
    string ruta = @"c:\my_chess_program\table3.txt";
    string myname = "Anthony Jhorel Inca Figueroa";
    File.WriteAllText(ruta, myname);
}