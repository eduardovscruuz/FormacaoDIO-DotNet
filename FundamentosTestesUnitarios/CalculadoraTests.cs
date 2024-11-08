using System.Runtime.InteropServices;
using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }


    [Fact]
    public void DeveSomar5Com10Retornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10Retornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resultado);
    }
    [Fact]
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        //Arrange
        int numero = 4;

        // Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeNumerosSaoParesERetornarTrue(int[] numeros)
    {
        //Act & // Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }

}
