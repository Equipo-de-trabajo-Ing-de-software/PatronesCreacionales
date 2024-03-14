
namespace PatronesCreacionale.AbstractFactory
{
    //Cada fabrica debe implementar esta interfaz 
    public interface IMainFactory
    {
        IStakeholder CreateStakeholder();
        IProveedor CreateProveedor();


    }
}
