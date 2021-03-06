﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPatronesMike.Bussines.Interface;

namespace ExamenPatronesMike.Bussines
{
    public class PaqueteriaEstafeta : IPaqueteria
    {
        private double dMargenUtilidad;
        public PaqueteriaEstafeta(double _dMargenUtilidad)
        {
            this.dMargenUtilidad = _dMargenUtilidad;
        }

        public DateTime ObtenerFechaEntrega(DateTime _dtFechaPedito, double _dHoras)
        {
            return _dtFechaPedito.AddHours(_dHoras);
        }
        public double ObtenerMargenUtilidad()
        {
            return this.dMargenUtilidad;
        }
    }
}
