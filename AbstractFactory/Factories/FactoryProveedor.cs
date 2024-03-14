﻿using PatronesCreacionale.AbstractFactory.ConcreteClasses;



namespace PatronesCreacionale.AbstractFactory.Factories
{
    public class FactoryProveedor : IMainFactory
    {
        public IProveedor CreateProveedor()
        {
            return new Proveedor();
        }

        public IStakeholder CreateStakeholder()
        {
            return new Stakeholder();
        }
    }
}
