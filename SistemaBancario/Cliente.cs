﻿using System;
namespace SistemaBancario
{
    [Serializable]
    public class Cliente
    {
        public int Cpf;
        public string Nome;
        public DateTime Data_Nascimento;
        public string Email;
        public bool NomeSujo;

        public Cliente()
        {

        }

    }
}
