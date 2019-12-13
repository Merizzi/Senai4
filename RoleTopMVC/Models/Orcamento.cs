using System;
using RoleTopMVC.Enums;
using Microsoft.Extensions.Primitives;

namespace RoleTopMVC.Models
{
    public class Orcamento
    {
        public string Evento {get;set;}

        public Cliente Cliente {get;set;}
        public DateTime DataEvento {get;set;}
        public DateTime Horario {get;set;} 
        public string Servicos {get;set;}
        public string Descricao {get;set;}
        public string Celular {get;set;}
        public ulong Id {get;set;}
        public string FormaPagamento {get;set;}
        public uint Status {get;set;}

        public Orcamento()
        {
            this.Cliente = new Cliente();
            this.Evento = Evento;
            this.Horario = Horario;
            this.Servicos = Servicos;
            this.Descricao = Descricao;
            this.FormaPagamento = FormaPagamento;
            this.Celular = Celular; 
            this.DataEvento = DataEvento;
            this.Id = 0;
            // this.Status = (uint) StatusPedido.PENDENTE;
        }
    }
}