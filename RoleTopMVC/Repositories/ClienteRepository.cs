using System;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";
        
        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string [] { PrepararRegistroCSV(cliente)} ;
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public Cliente ObterPor( string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
               if(ExtrairValorDoCampo("email", item).Equals(email))
               {
                   Cliente c = new Cliente();
                   c.Nome = ExtrairValorDoCampo("nome", item);
                   c.Sobrenome = ExtrairValorDoCampo("sobrenome", item);
                   c.Email = ExtrairValorDoCampo("email", item);
                   c.Cpf = ExtrairValorDoCampo ("cpf", item);
                   c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", item));
                   c.Senha = ExtrairValorDoCampo ("senha", item);

                   return c;  
               } 
            }
            return null;
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};sobrenome={cliente.Sobrenome};email={cliente.Email};cpf={cliente.Cpf};data_nascimento={cliente.DataNascimento};senha={cliente.Senha}";
        }

    }
}