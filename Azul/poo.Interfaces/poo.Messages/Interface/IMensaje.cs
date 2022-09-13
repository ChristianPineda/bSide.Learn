namespace poo.Messages.Interface
{
    public interface IMensaje
    {
        string Mensaje(string mensaje);
        string Remitente(string remitente);
        string Destinatario(string destinatario);
    }
}