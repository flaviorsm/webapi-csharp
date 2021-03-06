﻿using System;

namespace dws.gegraf.domain
{
    public class Usuario
    {
        public Usuario()
        {
            this.DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
