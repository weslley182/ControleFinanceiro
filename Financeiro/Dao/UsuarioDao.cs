﻿using Financeiro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financeiro.Dao
{
    public class UsuarioDao
    {
        private FinancasContext context;

        public UsuarioDao(FinancasContext context)
        {
            this.context = context;
        }

        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }
        public IList<Usuario> Lista()
        {
            return context.Usuarios.ToList();
        }
    }
}