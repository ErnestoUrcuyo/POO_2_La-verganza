using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
     
    public class Estaciones
    {
        public Estacion primavera;
        public Estacion Primavera
        {
            get
            {
                if(this.primavera == null)
                {
                    primavera = new Estacion(6, 21, 9, 20);
                }
                return primavera;
            }
        }
        public Estacion verano;
        public Estacion Verano
        {
            get
            {
                if(this.verano == null)
                {
                    verano = new Estacion(6, 21, 8, 20);
                }
                return verano;
            }
        }
        public Estacion otoño;
        public Estacion Otoño
        {
            get
            {
                if(this.otoño == null)
                {
                    otoño = new Estacion(6, 21, 9, 20);
                }
                return otoño;
            }
        }
        public Estacion invierno;
        public Estacion Invierno
        {
            get
            {
                if(this.invierno == null)
                {
                    invierno = new Estacion(6, 21, 9, 20);         
                }
                return invierno;
            }
        }
        public class Estacion
        {
            public Estacion(byte mesInicio, byte diaInicio, byte mesFin, byte diaFin)
            {
                this.MesInicio = mesInicio;
                this.DiaInicio = diaInicio;
                this.MesFin = mesFin;
                this.DiaFin = diaFin;
            }

            public byte MesInicio { get; set; }
            public byte DiaInicio { get; set; }
            public byte MesFin { get; set; }
            public byte DiaFin { get; set; }
        }

    }
}
