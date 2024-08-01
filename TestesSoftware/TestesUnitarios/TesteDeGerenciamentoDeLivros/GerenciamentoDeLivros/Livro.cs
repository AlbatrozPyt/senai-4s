using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeLivros
{
    public class Livro
    {
        public string Nome { get; set; }
        public string Sinpose { get; set; }
        public string Autor { get; set; }

        public static List<Livro> AdicionarLivro(Livro livro, List<Livro> livros)
        {
            livros.Add(livro);

            return livros;
        }
    }
}
