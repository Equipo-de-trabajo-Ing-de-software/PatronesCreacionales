namespace PatronesCreacionale.AbstractFactory
{
    public interface IStakeholder
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        void Render();
    }
}