namespace Lunes21
{
    public class Vehiculo
    {
        private string marca;
        private int velocidad;

        public static int cantidadVehiculos;

        public Vehiculo(string marca, int velocidad)
        {
            this.marca = marca;
            this.velocidad = velocidad;
        }

        // como el this() en Java
        public Vehiculo() : this("Fiat", 0) { }

        public String GetMarca() { return this.marca; }
        public void SetMarca(Vehiculo vehiculo, String newMarca)
        {
            vehiculo.marca = newMarca;
        }

        // get set shorthand
        public string Marca
        {
            get => this.marca;
            set => this.marca = value;
            // private set => this.marca = value;
        }
        public void Acelerar(int valor)
        {
            this.Acelerar(valor, false);
        }
        public void Acelerar(int valor, bool turbo)
        {
            velocidad += valor;
            if (turbo)
            {
                Console.WriteLine("Acelerando {0} km/h con turbo", valor);
            }
            else
            {
                Console.WriteLine("Acelerando {0} km/h", valor);
            }
        }
    }
}
