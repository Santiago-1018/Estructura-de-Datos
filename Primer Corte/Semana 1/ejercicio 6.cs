using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ToString;

namespace DiasHorasMinutoySegundos
{
    class Program
    {
        static void Main(string[] args)
        {

private String CalcularTiempo(Int32 tsegundos)
{
        Int32 horas = (tsegundos / 3600);
        Int32 minutos = ((tsegundos-horas*3600)/60);
        Int32 segundos = tsegundos-(horas*3600+minutos*60);
        return horas.ToString() + ":" + minutos.ToString() + ":" + segundos.ToString();
        }
        }
    }
}