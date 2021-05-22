using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TP2
{
    class Usuario
    {
        protected int DNI;
        protected string nombre;
        protected string mail;
        protected string password;
        protected bool esAdmin;
        protected bool bloqueado;

        public Usuario()
        {
        }

        public Usuario(int DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.mail = mail;
            this.password = password;
            this.esAdmin = esAdmin;
            this.bloqueado = bloqueado;
        }        

        public int getDNI() { return DNI; }
        public void setDNI(int DNI) { this.DNI = DNI; }

        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }

        public string getMail() { return mail; }
        public void setMail(string mail) { this.mail = mail; }

        public string getPassword() { return password; }
        public void setPassword(string password) { this.password = password; }

        public bool getEsAdmin() { return esAdmin; }
        public void setEsAdmin(bool esAdmin) { this.esAdmin = esAdmin; }

        public bool getBloqueado() { return bloqueado; }
        public void setBloqueado(bool bloqueado) { this.bloqueado = bloqueado; }


    }
}