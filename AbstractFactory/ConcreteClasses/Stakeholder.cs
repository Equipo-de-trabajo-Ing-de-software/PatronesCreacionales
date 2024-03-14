namespace PatronesCreacionale.AbstractFactory.ConcreteClasses
{
    public class Stakeholder : IStakeholder
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void Render()
        {
            Console.WriteLine("Cliente Stakeholder creado Correctamente!");
            Console.WriteLine($"Nombre: {Name}, Email: {Email}, Teléfono: {Phone}");
        }
    }
}