using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlaylist
{
    internal class MasterClas
    {
        private int Edad;
        private string NombreCompleto;
        private string Dni;


        public MasterClas(int edad, string nombre, string dni)
        {
            Edad = edad;
            NombreCompleto = nombre;
            Dni = dni;
        }


        public int getEdad()
        {
            return Edad;
        }

        public void setEdad(int edad)
        {
            this.Edad = edad;
        }


        public String getNombreCompleto()
        {
            return NombreCompleto;
        }

        public void setNombreCompleto(string nombre)
        {
            this.NombreCompleto = nombre;
        }

        public String getDni()
        {
            return Dni;
        }

        public void setDni(string dni)
        {
            this.Dni = dni;
        }

    }

}
