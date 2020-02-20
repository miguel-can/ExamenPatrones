using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesMike.Bussines.Interface
{
    public interface ICreadorInstanciaPedido
    {
        List<PedidoDTO> ObtenerListaPedidoDTO(string _cSeparador, DateTime _dtHoy, string[] arrContenido);
    }
}
