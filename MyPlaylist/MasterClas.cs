using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlaylist
{
    internal class MasterClas
    {
        private int _Edad;

        public int Edad
        {
            get => _Edad;
            set => _Edad = value;
        }

        private string _NombreCompleto;
        public string NombreCompleto
        {
            get => _NombreCompleto;
            set => _NombreCompleto = value;
        }


        private string _Dni;

        public string Dni
        {
            get => _Dni;
            set => _Dni = value;
        }

        private string _Correo;
        public string Correo
        {
            get => _Correo;
            set => _Correo = value;
        }

        public MasterClas(int edad, string nombre, string dni, string correo)
        {
            _Edad = edad;
            _NombreCompleto = nombre;
            _Dni = dni;
            _Correo= correo;
        }
       

    }

}
