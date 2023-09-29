using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using projeto.Services;

namespace projetoTeste;

public class ValidaString
{
    private ValidaStringsImplementation _valida;

    public ValidaString()
    {
        _valida = new  ValidaStringsImplementation();
    }


    [Fact]
    public void TesteMetodoContarCaracetes()
    {
        string txt = "implementando validações de string";

        var resultado = _valida.ContaTexto(txt);

        Assert.Equal(34, resultado);
    
    }
}
