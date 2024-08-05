using ControleDeInventario;

namespace ProdutoA.Test
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            // Instância um novo produto
            Produto prod = new Produto();
            prod.NomeProduto = "Cachorro";
            prod.Qtd = 1;

            // Instância um nova lista
            var listaProdutos = new List<Produto>();

            // Executa a funcao pela primeira vez
            var res = Produto.AdicionarProduto(prod, listaProdutos);

            // Verifica se o produto foi adicionado
            var ver1 = listaProdutos.FirstOrDefault(x => x.NomeProduto == "Cachorro");

            // Verifica se o elemento foi encontrado
            Assert.NotNull(ver1);

            // Instância um novo produto
            Produto prod1 = new Produto();
            prod1.NomeProduto = "Cachorro";
            prod1.Qtd = 6;

            // Executa a funcao pela segunda vez
            res = Produto.AdicionarProduto(prod1, listaProdutos);
            var ver2 = listaProdutos.FirstOrDefault(x => x.NomeProduto == "Cachorro");

            // Verifica se a quantidade do produto foi incrementada
            Assert.Equal(7, ver2.Qtd);


            var ver3 = listaProdutos.FirstOrDefault(x => x.NomeProduto == "Cachorro");

            Assert.NotNull(ver3);
        }
    }
}