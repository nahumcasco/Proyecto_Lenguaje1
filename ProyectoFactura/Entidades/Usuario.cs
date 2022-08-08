﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        //Propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public byte[] Foto { get; set; }

        public Usuario() { }

        public Usuario(string codigo, string nombre, string clave, string correo, string telefono, byte[] foto)
        {
            Codigo = codigo;
            Nombre = nombre;
            Clave = clave;
            Correo = correo;
            Telefono = telefono;
            Foto = foto;
        }

        public Usuario(string codigo, string clave)
        {
            Codigo = codigo;
            Clave = clave;
        }
    }
}
