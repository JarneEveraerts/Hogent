using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IOnderhoudRepository
    {
        List<Onderhoud> GeefOnderhoudVanAutos();
    }
}