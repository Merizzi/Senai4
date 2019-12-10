using System;
using Microsoft.Extensions.Primitives;

namespace RoleTopMVC.Models
{
    public class Orcamento
    {
        public string Evento {get;set;}

        public Cliente Cliente {get;set;}
        public DataTime Evento {get;set;}
        public Time Horario {get;set} 
        public string Descricao {get;set;}
        public string Celular {get;set;}

        public Orcamento()
        {
            this.Cliente = new Cliente();
            
        }
    }
}