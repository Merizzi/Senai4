using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class OrcamentoRepository : RepositoryBase
    {
        private const string PATH = "Database/Orcamento.csv";

        public OrcamentoRepository(){
            if(!File.Exists(PATH)){
                File.Create (PATH).Close();
            }
        }

        public bool Inserir (Orcamento orcamento){
            var quantidadeOrcamentos = File.ReadAllLines(PATH).Length;
            orcamento.Id = (ulong) ++quantidadeOrcamentos;
            var linha = new string [] { PrepararOrcamentoCSV (orcamento)};
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Orcamento> ObterTodosPorCliente(string emailCliente)
        {
            var orcamentos = ObterTodos();
            List<Orcamento> orcamentosCliente = new List<Orcamento>();

            foreach(var orcamento in orcamentos)
            {
                if(orcamento.Cliente.Email.Equals(emailCliente))
                {
                    orcamentosCliente.Add(orcamento);
                }
            }
            return orcamentosCliente;
        }

        public List<Orcamento> ObterTodos(){
            var linhas = File.ReadAllLines(PATH);
            List<Orcamento> pedidos = new List<Orcamento>();

            foreach (var linha in linhas){
                Orcamento orcamento = new Orcamento();

                orcamento.Cliente.Nome= ExtrairValorDoCampo("cliente_nome", linha);
                orcamento.Cliente.Email = ExtrairValorDoCampo ("cliente_email", linha);
                orcamento.Cliente.Cpf = ExtrairValorDoCampo("cliente_cpf", linha);
                orcamento.Evento = ExtrairValorDoCampo("evento", linha);
                orcamento.Horario = DateTime.Parse(ExtrairValorDoCampo("horario", linha));

                orcamento.Add(orcamento);
            }
            return orcamentos;
        }

        private string PrepararOrcamentoCSV (Orcamento orcamento){
            Cliente c = orcamento.Cliente;

            return $"cliente_nome={c.Nome};cliente_email{c.Email};cliente_cpf{c.Cpf};evento={orcamento.Evento};horario={orcamento.Horario}";
        }

    }
}