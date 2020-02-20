using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;

namespace ExamenPatronesMike.Bussines
{
    public class PaqueteriaDHL : IPaqueteria
    {
        private double dMargenUtilidad;
        private ITipoTransporte svrTipoTransporte;

        public PaqueteriaDHL(ITipoTransporte _svrTipoTransporte,double _dMargenUtilidad)
        {
            this.svrTipoTransporte = _svrTipoTransporte;
            this.dMargenUtilidad = _dMargenUtilidad;
        }

        public DateTime ObtenerFechaEntrega(DateTime _dtFechaPedito, double _dHoras)
        {
            return _dtFechaPedito.AddHours(_dHoras);
        }
        public double ObtenerMargenUtilidad()
        {
            return this.dMargenUtilidad;
        }

        public string ComparaCostoEnvio(double _dCostoEnvio)
        {
            double dCostoEnvioActual = 0;
            string cRespuesta = string.Empty;

            if (_dCostoEnvio != 0)
            {
                if (_dCostoEnvio < dCostoEnvioActual)
                    return GeneraMensajeEconomico(dCostoEnvioActual);
            }

            return cRespuesta;
        }

        private string GeneraMensajeEconomico(double dEnvio)
        {
            return string.Format("En la paqueteria DHL te sale más barato: " + );
        }
        
    }
}
