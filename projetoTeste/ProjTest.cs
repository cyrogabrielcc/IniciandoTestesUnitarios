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


        var result = _calc.subtrair(var1, var2);
        Assert.Equal(0, result);
    }
}