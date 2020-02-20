using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;

namespace ExamenPatronesMike.Bussines
{
    public class GeneradorMensajePedidoService : IGeneradorMensajePedido
    {
        public string GeneraMensaje(PedidoDTO entPedidoDTO)
        {
            return string.Format("Tu paquete {0} de {1} y {2} a {3} el {4} y {5} un costo de {6} (cualquier reclamación con {7})",
                                    (entPedidoDTO.lEsFechaActual ? "saldra" : "salio"), entPedidoDTO.cOrigen, (entPedidoDTO.lEsFechaActual ? "llegará" : "llego"), entPedidoDTO.cDestino,
                                    entPedidoDTO.FechaEntrega.ToShortDateString(), (entPedidoDTO.lEsFechaActual ? "tendra" : "tuvo"), entPedidoDTO.dCostoEnvio.ToString(), entPedidoDTO.cPaqueteria);
        }
    }
}
