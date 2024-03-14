
namespace FactoryMethod.Requisitos
{
    public class NonFunctionalRequirement : IRequirement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } = "No Funcional";
        public int Priority { get; set; }

        public void Edit(string title, string description, int priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
        }

        public void Delete()
        {
            Console.WriteLine("Requisito Eliminado");
        }
    }
}
