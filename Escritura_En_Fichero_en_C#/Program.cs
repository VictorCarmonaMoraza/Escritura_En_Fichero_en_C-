using System;
using System.IO;

namespace Escritura_En_Fichero_en_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ficheroPruebas = @"C:\Users\Victo\OneDrive\Escritorio\Proyectos 2023\Ficheros_NET\Lectura_fichero_de_texto_C#\ficherosParaLeer\ficheroPrueba.txt";
            string ficheroPruebas1 = @"C:\Proyectos2023\NET\FicherosZIP\CrearFicheroZIP\CrearFicheroZIP\bin\Debug\net5.0\fac.pdf";
            /*Creamos la variable fichero con la clase FileStream pasandola ruta
             * del fichero, el modo de apertura (en este caso, vamos a añadir datos
             * al final del fichero -->Append) y como vamos a acceder a el (escritura)
             * */

            FileStream fichero = new FileStream(ficheroPruebas, FileMode.Append, FileAccess.Write);

            //Abrimos el flujo de escritura
            StreamWriter fs = new StreamWriter(fichero);

            //Pedimos al usuario una cadena de texto la escribiremos en el fichero 
            string frase =Console.ReadLine();

            //mensaje para poder empezar a escribir
            Console.WriteLine("Empieza a escribir");
            //Escribimos 
            fs.WriteLine(frase);

            //Cerramos el flujo y el fichero
            fs.Close();
            fichero.Close();
        }
    }
}
