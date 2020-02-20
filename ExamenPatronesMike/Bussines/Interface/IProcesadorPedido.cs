using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesMike.Bussines.Interface
{
    public interface IProcesadorPedido
    {
        List<MensajePedidoDTO> ProcesarPedido(List<PedidoDTO> _lstPedidos);
    }
}
