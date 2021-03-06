﻿using Core.Contratos;
using Core.Modelo;

namespace Infraestructura
{
    public class RepositorioCredencialActiveDirectory : IRepositorioCredencial
    {
        private readonly string _ruta;

        public RepositorioCredencialActiveDirectory(string ruta)
        {
            _ruta = ruta;
        }

        public bool AutenticarUsuario(Credencial credencial)
        {
            return true;
        }
    }
}
