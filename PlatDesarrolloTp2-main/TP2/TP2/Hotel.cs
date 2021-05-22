using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    class Hotel : Alojamiento
    {
        protected float precioPorPersona;

        public Hotel()
        {

        }
        public Hotel(int Codigo, string Nombre, string Ciudad, string Barrio, int Estrellas, int CantPersonas, bool Tv, float PrecioPP)
        {
            this.codigo = Codigo;
            this.nombre = Nombre;
            this.ciudad = Ciudad;
            this.barrio = Barrio;
            this.estrellas = Estrellas;
            this.cantPersonas = CantPersonas;
            this.tv = Tv;
            this.precioPorPersona = PrecioPP;
        }
        public void setPrecioPorPersona(float nuevoPrecioPP) { precioPorPersona = nuevoPrecioPP; }

        public float getPrecioPorPersona() { return precioPorPersona; }

        public override string ToString()
        {
            return base.ToString() + " Precio: " + precioPorPersona;
        }

    }
}
