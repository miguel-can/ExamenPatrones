using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;

namespace ExamenPatronesMike.Bussines
{
    public class ImpresorArchivoService : IImpresorPedidos
    {
        public void ImprimirPedido(List<MensajePedidoDTO> lstListaPedidos)
        {

            //Tu paquete[Expresión1] de[Origen] y[Expresión2] a[Destino] el
            //[Fecha de ENTREGA] y[Expresión4] un costo de[Costo de envío]
            //(Cualquier reclamación con[Paquetería]).

            //Tu paquete salió de Ticul y llegó a Motul y tuvo un costo de $480(cualquier reclamación
            //con Estafeta).

            foreach (MensajePedidoDTO item in lstListaPedidos)
            {
                Console.WriteLine(item.cMensaje);
            }
        }       
    }
}
