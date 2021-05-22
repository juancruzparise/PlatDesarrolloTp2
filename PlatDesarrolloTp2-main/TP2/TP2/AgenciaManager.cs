using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TP2
{
    class AgenciaManager
    {

        protected Agencia miAgencia;
        protected List<Usuario> misUsuarios;
        protected List<Reserva> misReservas;

        protected List<Alojamiento> misAlojamientos;

        protected int dniConAuticacionFalsa;
        protected int cantidadDeIntentosDeInicio = 0;

        public AgenciaManager()
        {
            var usr1 = new Usuario();
            usr1.setDNI(1111);
            usr1.setPassword("abc");
            usr1.setEsAdmin(true);

            var usr2 = new Usuario();
            usr2.setDNI(2222);
            usr2.setPassword("abc");
            usr2.setEsAdmin(false);

            misUsuarios = new List<Usuario>() { usr1, usr2 };
        }

        public List<string> buscarAlojamiento(string ciudad, DateTime pDesde, DateTime pHasta, int cantPersonas, string tipo)
        {
            var lst = new List<string>();

            foreach (var item in misReservas)
            {
                if (tipo == "Hotel")
                {
                    if (item is Hotel)
                    {
                        if (item.getPropiedad().getCiudad() == ciudad
                            && item.getFDesde() == pDesde
                            && item.getFHasta() == pHasta
                            && item.getPropiedad().getCantPersonas() == cantPersonas)
                        {
                            lst.Add(item.getPropiedad().getNombre());
                        }
                    }
                }

                if (tipo == "Cabaña")
                {
                    if (item is Cabaña)
                    {
                        if (item.getPropiedad().getCiudad() == ciudad
                            && item.getFDesde() == pDesde
                            && item.getFHasta() == pHasta
                            && item.getPropiedad().getCantPersonas() == cantPersonas)
                        {
                            lst.Add(item.getPropiedad().getNombre());
                        }
                    }
                }
            }

            return lst;
        }

        public bool agregarAlojamientos(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.igualCodigo(aloj))
                {
                    return false;
                }

            //si llegó hasta acá es porque no está ese código
            misAlojamientos.Add(aloj);

            return true;
        }
        public bool modificarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.igualCodigo(aloj))
                {
                    misAlojamientos.Remove(aloj);
                    misAlojamientos.Add(aloj);
                    return true;
                }

            //si llegó hasta acá es porque no está ese código
            return false;
        }

        public bool quitarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.igualCodigo(aloj))
                {
                    misAlojamientos.Remove(aloj);
                    return true;
                }
            //si llegó hasta acá es porque no está ese código
            return false;
        }

        public List<string> buscarReservas(int DNI)
        {
            var lst = new List<string>();

            foreach (var item in misReservas)
            {
                if (item.getPersona().getDNI() == DNI)
                {
                    lst.Add(item.getPropiedad().getNombre());
                }
            }

            return lst;
        }

        public bool reservar(int codAloj, int dniUsuario, DateTime FDesde, DateTime FHasta)
        {
            Alojamiento alo = null;
            Usuario usr = null;

            foreach (var item in misAlojamientos)
            {
                if (item.getCodigo() == codAloj)
                {
                    alo = item;
                }
            }

            foreach (var item in misUsuarios)
            {
                if (item.getDNI() == dniUsuario)
                {
                    usr = item;
                }
            }

            if (alo == null && usr == null)
            {
                return false;
            }

            var reserva = new Reserva();
            reserva.setPropiedad(alo);
            reserva.setPersona(usr);
            reserva.setFDesde(FDesde);
            reserva.setFHasta(FHasta);

            return true;
        }

        public bool ModificarReserva(Reserva reserve)
        {
            foreach (Reserva r in misReservas)
                if (r.igualIdReserva(reserve))
                {
                    misReservas.Remove(reserve);
                    misReservas.Add(reserve);
                    return true;
                }

            return false;
        }

        public bool eliminarReserva(Reserva reserve)
        {
            foreach (Reserva r in misReservas)
                if (r.igualIdReserva(reserve))
                {
                    misReservas.Remove(reserve);
                    return true;
                }

            //si llegó hasta acá es porque no está ese código
            return false;
        }

        public Usuario autenticarUsuario(int DNI, string password)
        {
            foreach (var item in misUsuarios)
            {
                if (item.getDNI() == DNI && item.getPassword() == password)
                {
                    return item;
                }
            }

            if (dniConAuticacionFalsa == DNI)
            {
                cantidadDeIntentosDeInicio++;

                if (cantidadDeIntentosDeInicio == 3)
                {
                    foreach (var item in misUsuarios)
                    {
                        if (item.getDNI() == DNI)
                        {
                            item.setBloqueado(true);
                        }
                    }
                }
            }
            else
            {
                dniConAuticacionFalsa = DNI;
                cantidadDeIntentosDeInicio = 1;
            }

            return null;
        }

        public bool desbloquearUsuario(int DNI)
        {
            foreach (var item in misUsuarios)
            {
                if (item.getDNI() == DNI)
                {
                    item.setBloqueado(false);

                    return true;
                }
            }

            return false;
        }

        public bool AgregarUsuario(Usuario user)
        {
            foreach (Usuario u in misUsuarios)
                if (u.getDNI() == user.getDNI())
                    return false;

            //si llegó hasta acá es porque no está ese código
            misUsuarios.Add(user);
            return true;

        }

        public bool modificarUsuario(Usuario user)
        {
            foreach (Usuario u in misUsuarios)
                if (u.getDNI() == user.getDNI())
                {
                    misUsuarios.Remove(u);
                    misUsuarios.Add(user);
                    return true;
                }

            return false;
        }

        public bool eliminarUsuario(Usuario user)
        {
            foreach (Usuario u in misUsuarios)
                if (u.getDNI() == user.getDNI())
                {
                    misUsuarios.Remove(u);
                    return true;
                }

            return false;
        }
    }
}
