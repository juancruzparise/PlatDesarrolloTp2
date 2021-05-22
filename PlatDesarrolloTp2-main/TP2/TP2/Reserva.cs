using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TP2
{
    class Reserva
    {
        private int id;
        private DateTime FDesde;
        private DateTime FHasta;
        private Alojamiento propiedad;
        private Usuario persona;
        private float precio;

        public Reserva()
        {

        }
        public Reserva(int id, DateTime FDesde, DateTime FHasta, Alojamiento propiedad, Usuario persona, float precio)
        {
            this.id = id;
            this.FDesde = FDesde;
            this.FHasta = FHasta;
            this.propiedad = propiedad;
            this.persona = persona;
            this.precio = precio;
        }
        public bool igualIdReserva(Reserva r)
        {
            return id == r.getId();
        }
        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        public DateTime getFDesde() { return FDesde; }
        public void setFDesde(DateTime FDesde) { this.FDesde = FDesde; }

        public DateTime getFHasta() { return FHasta; }
        public void setFHasta(DateTime FHasta) { this.FHasta = FHasta; }

        public Alojamiento getPropiedad() { return propiedad; }
        public void setPropiedad(Alojamiento propiedad) { this.propiedad = propiedad; }

        public Usuario getPersona() { return persona; }
        public void setPersona(Usuario persona) { this.persona = persona; }

        public float getPrecio() { return precio; }
        public void setPrecio(float precio) { this.precio = precio; }




    }
}