using SuportesBalanceados.Application;
using Xunit;

namespace SuportesBalanceados.Test;

public class TesteValidaColchetes
{
    [Fact]
    public void TestarSequenciaVazia()
    {
        string s = "";
        bool resultado = ValidaColchetes.Validar(s);
        Assert.True(resultado);
    }

    [Fact]
    public void TestarSequenciaValida()
    {
        string s = "({[]})";
        bool resultado = ValidaColchetes.Validar(s);
        Assert.True(resultado);
    }

    [Fact]
    public void TestarSequenciaInvalida()
    {
        string s = "{[})]";
        bool resultado = ValidaColchetes.Validar(s);
        Assert.False(resultado);
    }

    [Fact]
    public void TestarSequenciaComCaracteresNaoColchetes()
    {
        string s = "abcde";
        bool resultado = ValidaColchetes.Validar(s);
        Assert.False(resultado);
    }

    [Fact]
    public void TestarSequenciaComColchetesNaoCorrespondentes()
    {
        string s = "({[}])";
        bool resultado = ValidaColchetes.Validar(s);
        Assert.False(resultado);
    }
}