using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;

namespace ExamenPatronesMike.Bussines
{
    public class TipoTransporteAvion : ITipoTransporte
    {
        private double dCostoXKm;
        private double dDistancia;

        public TipoTransporteAvion(double _dCostoXKm, double _dDistancia)
        {
            this.dCostoXKm = _dCostoXKm;
            this.dDistancia = _dDistancia;
        }

        public double ObtenerCostoEnvio(double _dMargenUtilidad)
        {
            return (dCostoXKm * dDistancia * (1 + _dMargenUtilidad));
        }

        public double ObtenenerTiempoEntrega(double _dVelocidadEntregaKm)
        {
            return (dDistancia / _dVelocidadEntregaKm);
        }
    }
}
