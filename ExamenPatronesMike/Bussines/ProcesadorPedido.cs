using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;
using ExamenPatronesMike.Factory;
using ExamenPatronesMike.Factory.Interface;

namespace ExamenPatronesMike.Bussines
{
    public class ProcesadorPedido : IProcesadorPedido
    {
        private IPaqueteria svrPaqueteria;

        public ProcesadorPedido(IPaqueteria _svrPaqueteria)
        {
            this.svrPaqueteria = _svrPaqueteria;
        }

        public List<MensajePedidoDTO> ProcesarPedido(List<PedidoDTO> _lstPedidos)
        {
            List<MensajePedidoDTO> lstMensaje = new List<MensajePedidoDTO>();
            MensajePedidoDTO entMensaje;

            ITipoTransporteFactory svrTransporteFac;
            IPaqueteriaFactory svrFact;

            IGeneradorMensajePedido svrGeneradorMensaje = new GeneradorMensajePedidoService();
            ITipoTransporte svrTipoTransporte;
            IPaqueteria svrPaqueteria;

            foreach (PedidoDTO item in _lstPedidos)
            {
                entMensaje = new MensajePedidoDTO();

                switch (item.cPaqueteria)
                {                    
                    case "DHL":
                        svrTransporteFac = new TipoTransporteAvionFactory();
                        svrFact = new PaqueteriaDHLFactory(svrTransporteFac.ObtenerInstancia());
                        svrPaqueteria = svrFact.ObtenerInstancia(40);
                        svrTipoTransporte = svrTransporteFac.ObtenerInstancia();
                        entMensaje.cMensaje = svrGeneradorMensaje.GeneraMensaje(item);
                        lstMensaje.Add(entMensaje);
                        break;
                    case "FEDEX":
                        break;

                    case "ESTAFETA":
                        break;
                }

            }

            return null;
        }
    }
}
