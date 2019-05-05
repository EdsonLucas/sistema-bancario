using System;
using System.Collections.Generic;

namespace SistemaBancario
{
    [Serializable]
    public class Gerente
    {
        public string Nome;
        public int Codigo;
        public int Senha;
        public int Cpf;

        public Gerente()
        {
            this.Nome = "Letícia";
            this.Codigo = 123;
            this.Senha = 123;
        }

    }
}
