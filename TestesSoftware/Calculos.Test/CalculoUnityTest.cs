using Xunit;

namespace Calculos.Test
{
    public class CalculoUnityTest
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            // Organizar (Arrange)
            var n1 = 5.5;
            var n2 = 1.5;

            var valorEsperado = 7;

            // Agir (Act)
            var soma = Calculo.Somar(n1, n2);

            // Provar (Asset)
            Assert.Equal(valorEsperado, soma);
        }


        [Fact]
        public void SubtrairDoisNumeros()
        {
            double n1 = 17;
            double n2 = 10;

            var valorEsperado = 7;

            var subtracao = Calculo.Subtrair(n1, n2);

            Assert.Equal(valorEsperado, subtracao);
        }

        [Fact]
        public void MultiplicarDoisNumeros()
        {
            double n1 = 3.5;
            double n2 = 2;

            var valorEsperado = 7;

            var multiplicar = Calculo.Multiplicar(n1, n2);

            Assert.Equal(valorEsperado, multiplicar);
        }

        [Fact]
        public void DividirDoisNumeros() 
        {
            double n1 = 14;
            double n2 = 2;

            var valorEsperado = 7;

            var dividir = Calculo.Dividir(n1, n2);

            Assert.Equal(valorEsperado, dividir);
        }

        [Fact]
        public void ModuloNumero()
        {
            double n1 = -7;

            var valorEsperado = 7;

            var modular = Calculo.Modular(n1);

            Assert.Equal(valorEsperado, modular);
        }
    }
}
