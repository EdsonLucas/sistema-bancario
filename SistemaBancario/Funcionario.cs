﻿using System;
using System.Collections.Generic;

namespace SistemaBancario
{
    [Serializable]
    public class Funcionario
    {
        public string Nome;
        public int Codigo;
        public int Cpf;

        public Funcionario(string Nome, int Codigo, int Cpf)
        {
            this.Nome = Nome;
            this.Codigo = Codigo;
            this.Cpf = Cpf;
        }
    }
}
