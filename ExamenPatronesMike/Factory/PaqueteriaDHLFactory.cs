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
    public class PaqueteriaDHLFactory : IPaqueteriaFactory
    {
        ITipoTransporte svrTipoTransporte;

        public PaqueteriaDHLFactory(ITipoTransporte _svrTipoTransporte)
        {
            this.svrTipoTransporte = svrTipoTransporte;
        }

        public IPaqueteria ObtenerInstancia(double _dMargenUtilidad)
        {
            return new PaqueteriaDHL(svrTipoTransporte, _dMargenUtilidad);
        }
    }
}
