namespace NavPageTelaAbas.Models;

public class CalculadoraImc
{
    public double Peso { get; set; }
    public double Altura { get; set; }

    public double CalcularImc()
    {
        if (Altura <= 0) return 0;
        return Peso / (Altura * Altura);
    }

    public string ObterClassificacaoHalloween(double imc)
    {
        if (imc < 18.5) return "Abaixo do peso";
        if (imc < 24.9) return "Peso normal";
        if (imc < 29.9) return "Sobrepeso";
        if (imc < 34.9) return "Obesidade Grau I";
        if (imc < 39.9) return "Obesidade Grau II";
        return "Obesidade Grau III";
    }
}