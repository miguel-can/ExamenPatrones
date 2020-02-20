using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;

namespace ExamenPatronesMike.Bussines
{
    public class TipoTransporteBarco //: ITipoTransporte
    {
        public double ObtenerCostoEnvio(double _dCostoXKm, double _dDistancia, double _dMargenUtilidad)
        {
            return (_dCostoXKm * _dDistancia * (1 + _dMargenUtilidad));
        }

        public double ObtenenerTiempoEntrega(double _dDistancia, double _dVelocidadEntregaKm)
        {
            return (_dDistancia / _dVelocidadEntregaKm);
        }
    }
}
