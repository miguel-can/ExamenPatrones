using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesMike
{
    public class PedidoDTO
    {
        public string cOrigen { get; set; }
        public string cDestino { get; set; }        
        public double dDistancia { get; set; }
        public string cPaqueteria { get; set; }
        public string cTipoTransporte { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool lEsFechaActual { get; set; }
        public DateTime FechaEntrega { get; set; }
        public double dCostoEnvio { get; set; }
    }
}
