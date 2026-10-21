namespace NavPageTelaAbas.Models;

public class Calculadora
{
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }
    public string Operacao { get; set; } = "+";

    public double Calcular()
    {
        return Operacao switch
        {
            "+" => Numero1 + Numero2,
            "-" => Numero1 - Numero2,
            "*" => Numero1 * Numero2,
            "/" => Numero2 != 0 ? Numero1 / Numero2 : throw new DivideByZeroException("Não é possível dividir por zero no caldeirão! 🧙‍♀️"),
            _ => 0
        };
    }
}