using Domain;
using Domain.Contracts;
using System.Collections.Generic;

namespace Infrastructure
{
    public class OnderhoudRepository : IOnderhoudRepository
    {
        public List<Onderhoud> GeefOnderhoudVanAutos() => OnderhoudMapper.GeefOnderhoudVanAutos();
    }
}
