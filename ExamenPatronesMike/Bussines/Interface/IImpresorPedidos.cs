using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesMike.Bussines.Interface
{
    public interface IImpresorPedidos
    {
        void ImprimirPedido(List<MensajePedidoDTO> lstListaPedidos);
    }
}
