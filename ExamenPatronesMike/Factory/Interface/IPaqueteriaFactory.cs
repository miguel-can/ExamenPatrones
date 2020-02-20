using ExamenPatronesMike.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesMike.Factory.Interface
{
    public interface IPaqueteriaFactory
    {
        IPaqueteria ObtenerInstancia(double _dMargenUtilidad);
    }
}
