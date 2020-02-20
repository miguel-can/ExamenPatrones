using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesMike.Bussines.Interface
{
    public interface IPaqueteria
    {
        DateTime ObtenerFechaEntrega(DateTime _dtFechaPedito, double _dHoras);
        double ObtenerMargenUtilidad();
    }
}
