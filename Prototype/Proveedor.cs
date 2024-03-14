

namespace Prototype
{
    public class Proveedor : Data
    {
        public Proveedor()
        {
            Name = "Empresa SIGES";
            Phone = "554561";
            Email = "siges@correo.com";
        }
        public override void Draw()
        {
            Console.WriteLine($"Datos de la Empresa:  \n  Nombre: {Name}, \n Teléfono: {Phone}, \n Correo: {Email}.");
        }
    }
}

