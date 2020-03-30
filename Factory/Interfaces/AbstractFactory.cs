using Factory;

namespace Factory_And_AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        IConnectionDB GetDB(EnumConnectionDB db);
        IConnectionREST GetRest(string service); 
    }
}
