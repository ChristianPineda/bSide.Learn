using System;
using poo.Messages.Interface;

namespace poo.Messages
{
    class Program
    {
        static void Main()
        {
            string m = "Hola";
            Mensaje mensaje = new Mensaje();
            IMensaje mensaje2 = new Mensaje();
            
            Console.WriteLine(mensaje.Destinatario("alguien@gmail.com"));
            Console.WriteLine(mensaje.Remitente("chris@gmail.com"));
            
            Console.WriteLine(mensaje2.Mensaje(m));
        }
    }
}