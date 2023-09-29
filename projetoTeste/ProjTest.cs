using projeto.Services;

namespace projetoTeste;

public class ProjTest
{
    public CalculatorImplementation _calc;

    public ProjTest()
    {
        _calc = new CalculatorImplementation();
    }

    [Fact]
    public void ExecutaSoma()
    {
        var var1 = 5;
        var var2 = 5;
        var resultSoma = _calc.Somar(var1, var2);
        Assert.Equal(10, resultSoma);


        var resulSubtrair = _calc.subtrair(var1, var2);
        Assert.Equal(0, resulSubtrair);
    }

    [Fact]
    public void Executasubtrair()
    {
        var var1 = 5;
        var var2 = 5;

        var resulSubtrair = _calc.subtrair(var1, var2);
        Assert.Equal(0, resulSubtrair);
    }

    [Fact]
    public void Executamultiplicacao()
    {
        var var1 = 0;
        var var2 = 5;

        var result = _calc.multiplicar(var1, var2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Executadividir()
    {
        var var1 = -5*-1;
        var var2 = 5;

        var result = _calc.dividir(var1, var2);
        Assert.Equal(1, result);
    }

    
    [Theory]
   /* [InlineData(50)]
    [InlineData(6)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(0)]
    [InlineData(90)]*/
    [InlineData(new double[] {1,2,3,4})]
    public void ParOuImpar(double[] nums)
    {
        Assert.All(nums, n => Assert.True(_calc.EhPAr(n)));
    }
}