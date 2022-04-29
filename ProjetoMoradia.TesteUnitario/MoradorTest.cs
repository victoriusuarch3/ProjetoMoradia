using Xunit;
using ProjetoMoradia.Models;
using System;

namespace ProjetoMoradia.TesteUnitario;

public class MoradorTest
{
    [Fact]
    public void MoradorDeveTerDataNascimentoEsperada()
    {
        //Preparando - Arrange
        var dataNascimentoEsperada = "04/04/2004";
        var nome = "Alan Sampaio";
        var morador = new Morador("Giovanni", "44455566678", dataNascimentoEsperada);
        //DataNascimento - Act
        var dataNascimento = morador.GetDataDeNascimento();

        Assert.Equal(dataNascimentoEsperada, dataNascimento.ToString("dd/MM/yyyy"));
    }
     [Fact]
    public void MoradorNaoDeveTerDataNascimentoMaiorQueADataAtual()
    {
        //Preparando - Arrange
        var dataNascimento = "28/04/2022";
        var morador = new Morador("Giovanni", "44455566678", dataNascimento);
        //DataNascimento - Act
        var dataNascimentoAtual = morador.GetDataDeNascimento().ToString("dd/MM/yyyy");

        Assert.Equal(dataNascimento, dataNascimentoAtual);
    }
    
    [Fact]
    public void SalvarNomeMorador()
    {
        var morador = new Morador("Victor", "5554443331", "25/03/1999");
        Assert.Equal("Victor", morador.GetNome());
    }
}