namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Salvando categorias com EF
            new Loja.Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(1, "Frutas");
            new Loja.Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria(2, "Eletrônicos");
        }
    }
}
