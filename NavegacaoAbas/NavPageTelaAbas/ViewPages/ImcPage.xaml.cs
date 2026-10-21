using System.Globalization;
using NavPageTelaAbas.Models;

namespace NavPageTelaAbas.ViewPages;

public partial class ImcPage : ContentPage
{
    public ImcPage()
    {
        InitializeComponent();
    }

    private async void BtnCalcularImc_Clicked(object sender, EventArgs e)
    {
        LblMsg.Text = string.Empty;

        if (!double.TryParse(TxtPeso.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double peso) || peso <= 0)
        {
            LblMsg.Text = "⚠️ Digite um peso válido!";
            return;
        }

        if (!double.TryParse(TxtAltura.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double altura) || altura <= 0)
        {
            LblMsg.Text = "⚠️ Digite uma altura válida!";
            return;
        }

        var imcCalc = new CalculadoraImc { Peso = peso, Altura = altura };
        double valorImc = imcCalc.CalcularImc();
        string classificacao = imcCalc.ObterClassificacaoHalloween(valorImc);

        var parametros = new Dictionary<string, object>
        {
            ["Operacao"] = $"IMC: {valorImc:F2}",
            ["Resultado"] = classificacao,
            ["Titulo"] = "Resultado Assustador 🧟‍♂️"
        };

        await Shell.Current.GoToAsync("resultado", parametros);
    }
}