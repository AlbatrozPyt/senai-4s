using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GerenciamentoDeLivros.Test
{
    public class LivrosUnityTest
    {
        [Fact]
        public void VerificarLivroAdicionado()
        {
            var livros = new List<Livro>();
            var livro = new Livro();

            livro.Nome = "I, Robot";
            livro.Sinpose = "Em 2035, é comum robôs serem usados como empregados e assistentes dos humanos. Para manter a ordem, esses robôs possuem um código que impede a violência contra humanos, a chamada Lei dos Robóticos. Quando Dr. Miles aparece morto e o principal suspeito é justamente um robô, acredita-se na possibilidade de que eles tenham encontrado um meio de desativar essa programação.";

            livro.Autor = "Isaac Asimov";

            var func = Livro.AdicionarLivro(livro, livros);

            var valorEsperado = livros.FirstOrDefault(x => x.Nome == "I, Robot");

            Assert.NotNull(valorEsperado);
        }
    }
}
