using Xunit;

namespace ValidacaoEmail.Test
{
    public class EmailUnityTest
    {
        [Theory]
        [InlineData("matheus@email.com")]
        [InlineData("matheusemail")]
        public void ValidarEmail(string email)
        {
            var res = Email.ValidarEmail(email);

            var valorEsperado = true;

            Assert.Equal(valorEsperado, res);
        }
    }
}