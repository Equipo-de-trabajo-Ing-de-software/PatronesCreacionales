using PatronesCreacionale.AbstractFactory;
using PatronesCreacionale.AbstractFactory.Factories;
using System.Numerics;
using System.Xml.Linq;

IMainFactory fabricaPrincipal = new FactoryStakeholder();
IStakeholder stakeholder = fabricaPrincipal.CreateStakeholder();

stakeholder.Name = "Juan Diego Ruiz";
stakeholder.Phone = "554561";
stakeholder.Email = "juan@correo.com";

stakeholder.Render();

Console.WriteLine();

IProveedor proveedor = fabricaPrincipal.CreateProveedor();
proveedor.Name = "Empresa SIGES";
proveedor.Phone = "1234597";
proveedor.Email = "siges@correo.com";
proveedor.Render();