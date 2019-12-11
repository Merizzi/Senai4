namespace RoleTopMVC.Models
{
    public class Servicos : Adicionais
    {
        
        public Servicos(){

        }

        public Servicos (string nome, double preco){
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}