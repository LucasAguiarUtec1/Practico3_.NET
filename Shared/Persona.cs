namespace Shared
{
    public class Persona
    {
        public string Nombre { get; set; } = "-- Sin Nombre --";

        public string Apellido { get; set; } = "";

        public string direccion { get; set; }
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public int telefono { get; set; }
        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public DateTime fechaNa { get; set; }

        public DateTime FechaNa
        {
            get
            {
                return fechaNa;
            }
            set
            {
                fechaNa = value;
            }
        }

        private string documento = "";
        public string Documento
        {
            get
            {
                return documento;
            }
            set
            {
                if (value.Length >= 7)
                {
                    documento = value;
                }
                else
                {
                    throw new Exception("El formato del documento no es correcto.");
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("-- Persona --");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Documento: " + Documento);
        }

        public void PrintTable()
        {
            Console.WriteLine("| " + Documento + " | " + Nombre + " | " +" | " + Telefono + " | " + FechaNa +  " | " + Direccion + " |");
        }
    }
}