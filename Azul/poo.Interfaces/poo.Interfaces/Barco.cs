namespace poo.Interfaces
{
    public class Barco:Vehiculo,IVehiculo
    {
        public int ruedas(int ruedas)
        {
            return ruedas;
        }
        public double motor(double motor)
        {
            return motor;
        }
        public string color(string color)
        {
            return color;
        }
        public string marca(string marca)
        {
            return marca;
        }
    }
}