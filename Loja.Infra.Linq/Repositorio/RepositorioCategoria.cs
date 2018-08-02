
namespace Loja.Infra.Linq.Repositorio
{
    public class RepositorioCategoria
    {
        public void AdicionarCategoria(int Id, string nome)
        {
            //Linq to Sql
            Categoria categoria = new Categoria();
            categoria.Id = Id;
            categoria.Nome = nome;

            LojaLinqToSqlDataContext linq = new LojaLinqToSqlDataContext();
            linq.Categoria.InsertOnSubmit(categoria);
            linq.SubmitChanges();

        }


    }
}
