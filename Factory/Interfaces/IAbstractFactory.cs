using Factory.Enums;
using Factory.Interfaces;

namespace Factory.Interfaces
{
    public interface IAbstractFactory
    {
        IConnectionDB GetDB(EnumConnectionDB db);
        IConnectionREST GetRest(string service); 
    }
}
