using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ServicosRepository : RepositoryBase
    {
        private const string PATH = "Database/Servicos.csv";        
        public ServicosRepository(){
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public double obterPrecoDe(string nomeServicos)
        {
            var lista = ObterTodos();
            double preco = 0.0;
            foreach(var item in lista)
            {
                if(item.Nome.Equals(nomeServicos))
                {
                    preco = item.Preco;
                }
            }
            return preco;
        }
        public List<Servicos> ObterTodos(){
            List<Servicos> servicos = new List<Servicos>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas)
            {
                Servicos s = new Servicos();
                string[] dados = linha.Split(";");
                s.Nome = dados[0];
                s.Preco = double.Parse(dados[1]);
                servicos.Add(s);
            }
            return servicos;
        }
    }
}