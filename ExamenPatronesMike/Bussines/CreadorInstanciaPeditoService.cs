using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;

namespace ExamenPatronesMike.Bussines
{
    public class CreadorInstanciaPeditoService : ICreadorInstanciaPedido
    {
        private string cSeparador;
        private DateTime dtHoy;

        public List<PedidoDTO> ObtenerListaPedidoDTO(string _cSeparador, DateTime _dtHoy, string[] arrContenido)
        {
            this.cSeparador = _cSeparador;
            this.dtHoy = _dtHoy;
            PedidoDTO entPedidoDTO;
            List<PedidoDTO> lstPedidos = new List<PedidoDTO>();
            foreach (var cLinea in arrContenido)
            {                
                ValidarEntrada(cLinea);
                entPedidoDTO = crearInstancia(cLinea);
                lstPedidos.Add(entPedidoDTO);
            }
            return lstPedidos;
        }

        private void ValidarEntrada(string _cLinea)
        {
            if (!_cLinea.Contains(cSeparador))
                throw new Exception("No tiene el formato correcto");
        }
        
        private PedidoDTO crearInstancia(string _cLinea)
        {
            PedidoDTO entPedido = new PedidoDTO();
            string[] arrayDatos = ExtraerCampos(_cLinea);
            AsignarCampos(entPedido, arrayDatos);
            return entPedido;
        }

        private string[] ExtraerCampos(string _cLinea)
        {
            return _cLinea.Split(cSeparador[0]);
        }

        private void AsignarCampos(PedidoDTO _entPedidoDTO, string[] _arrayDatos)
        {
            double dDistancia = 0;            
            double.TryParse(_arrayDatos[2], out dDistancia);

            //TimeSpan time = ObtenerDiferenciaFecha(dtFechaActual, dtEvento);
            _entPedidoDTO.cOrigen = _arrayDatos[0];
            _entPedidoDTO.cDestino = _arrayDatos[1];            
            _entPedidoDTO.dDistancia = dDistancia;
            _entPedidoDTO.cPaqueteria = _arrayDatos[3];
            _entPedidoDTO.cTipoTransporte = _arrayDatos[4];
            _entPedidoDTO.FechaPedido = DateTime.Parse(_arrayDatos[5]);
            _entPedidoDTO.lEsFechaActual = VerificarFechaActual(_entPedidoDTO.FechaPedido);
        }

        public bool VerificarFechaActual(DateTime _dtPedido)
        {
            return _dtPedido >= this.dtHoy;
        }
    }
}
