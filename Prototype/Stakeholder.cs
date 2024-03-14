

namespace Prototype
{
    public class Stakeholder : Data
    {
        public Stakeholder()
        {
            Name = "Lucas Perez";
            Phone = "6478961";
            Email = "correo@correo.com";
        }
        public override void Draw()
        {
            Console.WriteLine($"Datos del Cliente: \n  Nombre: {Name}, \n Teléfono : {Phone}, \n Correo: {Email}.");
        }
    }
}