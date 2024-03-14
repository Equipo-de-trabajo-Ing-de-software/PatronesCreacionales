namespace PatronesCreacionale.AbstractFactory.ConcreteClasses
{
    public class Proveedor : IProveedor
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void Render()
        {
            Console.WriteLine("Proveedor creado Correctamente!");
            Console.WriteLine($"Nombre: {Name}, Email: {Email}, Teléfono: {Phone}");
        }
    }
}