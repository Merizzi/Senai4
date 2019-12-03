using System;
using Microsoft.Extensions.Primitives;

namespace RoleTopMVC.Models
{
    public class Cliente
    {


        public string Nome {get;set;}
        public string Sobrenome {get;set;}
        public string Email {get;set;}
        public string Cpf {get;set;}
        public DateTime DataNascimento{get;set;}
        public string Senha {get;set;}
        public Cliente()
        {

        }

        public Cliente (string nome, string sobrenome, string email, string cpf, DateTime DataNascimento, string senha)
        {
            this.Nome= nome;
            this.Sobrenome = sobrenome; 
            this.Email = email;
            this.Cpf = cpf;
            this.DataNascimento = DataNascimento;
            this.Senha = senha;
        }
    }
}