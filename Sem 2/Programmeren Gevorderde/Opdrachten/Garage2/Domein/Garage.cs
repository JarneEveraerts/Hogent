using System;
using System.Collections.Generic;
using System.Linq;
using Main;

namespace Domein
{
    public class Garage
    {
        private IAutoRepository _autoRepo;
        private IOnderhoudRepository _onderhoudRepo;

        public Garage(IAutoRepository autoRepo, IOnderhoudRepository onderhoudRepo)
        {
            _autoRepo = autoRepo;
            _onderhoudRepo = onderhoudRepo;
        }

        public List<Auto> GeefAutos()
        {
            return _autoRepo.GeefAutos();
        }
    }
}