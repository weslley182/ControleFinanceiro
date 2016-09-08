﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financeiro.Entidades
{
    public class Movimentacao
    {
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public Tipo Tipo { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}