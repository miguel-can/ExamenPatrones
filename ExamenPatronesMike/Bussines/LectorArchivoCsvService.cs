using ExamenPatronesMike.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPatronesMike.Bussines
{
    public class LectorArchivoCsvService : ILectorArchivo
    {
        public string[] ObtenerContenido(string _cRuta)
        {
            return System.IO.File.ReadAllLines(_cRuta);
        }
    }
}
