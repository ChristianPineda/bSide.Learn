using poo.Messages.Interface;
namespace poo.Messages
{
    public class Mensaje: Correo, IMensaje
    { 
        string IMensaje.Mensaje(string mensaje)
        {
            return mensaje;
        }

        public string Remitente(string remitente)
        {
            return remitente;
        }

        public string Destinatario(string destinatario)
        {
            return destinatario;
        }
    }
}