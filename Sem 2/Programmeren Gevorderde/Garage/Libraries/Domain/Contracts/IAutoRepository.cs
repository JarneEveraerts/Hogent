using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IAutoRepository
    {
        List<Auto> Get();
        Auto Read(string nummerplaat);
        void Insert(Auto auto);
        void Delete(string nummerplaat);
        void Update(Auto auto);
    }
}
