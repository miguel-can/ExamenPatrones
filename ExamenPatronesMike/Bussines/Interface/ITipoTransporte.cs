using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesMike.Bussines.Interface
{
    public interface ITipoTransporte
    {
        double ObtenerCostoEnvio(double _dMargenUtilidad);
        /// <summary>
        /// El resultado devuelto es en Horas
        /// </summary>
        /// <returns></returns>
        double ObtenenerTiempoEntrega(double _dVelocidadEntregaKm);
    }
}
