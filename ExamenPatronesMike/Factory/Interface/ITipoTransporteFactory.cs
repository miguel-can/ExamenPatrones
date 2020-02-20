using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;

namespace ExamenPatronesMike.Factory.Interface
{
    public interface ITipoTransporteFactory
    {
        ITipoTransporte ObtenerInstancia();
    }
}
