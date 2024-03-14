namespace PatronesCreacionale.AbstractFactory
{
    public interface IProveedor
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        void Render();
    }
}