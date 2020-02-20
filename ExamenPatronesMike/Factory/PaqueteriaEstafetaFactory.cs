using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines;
using ExamenPatronesMike.Bussines.Interface;
using ExamenPatronesMike.Factory.Interface;

namespace ExamenPatronesMike.Factory
{
    public class PaqueteriaEstafetaFactory : IPaqueteriaFactory
    {
        public IPaqueteria ObtenerInstancia(double _dMargenUtilidad)
        {
            return new PaqueteriaEstafeta(_dMargenUtilidad);
        }
    }
}
