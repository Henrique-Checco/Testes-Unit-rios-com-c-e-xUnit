namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
    [Fact]
        public void Somar()
        {
            Assert.Equal(4, CalculadoraExemplo.Calculadora.Somar(2, 2));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(1, CalculadoraExemplo.Calculadora.Subtrair(3, 2));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(6, CalculadoraExemplo.Calculadora.Multiplicar(2, 3));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(3, CalculadoraExemplo.Calculadora.Dividir(6, 2));
        }

    }
}