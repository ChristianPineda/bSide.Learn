namespace poo.Interfaces
{
    public class carro: Vehiculo,IVehiculo
    {
        public int ruedas(int ruedas)
        {
            return ruedas;
        }
        public double motor(double motor)
        {
            return motor;
        }
        public string marca(string marca)
        {
            return "Toyota";
        }

        public string color(string color)
        {
            return color;
        }
    }
}