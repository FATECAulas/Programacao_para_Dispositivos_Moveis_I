using System.Globalization;
using NavPageTelaAbas.Models;

namespace NavPageTelaAbas.ViewPages;

public partial class CalcPage : ContentPage
{
    public CalcPage()
    {
        InitializeComponent();
        Routing.RegisterRoute("resultado", typeof(ResultPage));
    }

    private async void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        LblMsg.Text = string.Empty;

        if (!double.TryParse(TxtNum1.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double n1))
        {
            LblMsg.Text = "⚠️ Digite um primeiro número válido!";
            return;
        }

        if (!double.TryParse(TxtNum2.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double n2))
        {
            LblMsg.Text = "⚠️ Digite um segundo número válido!";
            return;
        }

        if (PckOperacao.SelectedIndex == -1)
        {
            LblMsg.Text = "⚠️ Selecione uma operação!";
            return;
        }

        var calc = new Calculadora
        {
            Numero1 = n1,
            Numero2 = n2,
            Operacao = PckOperacao.SelectedItem.ToString()!
        };

        try
        {
            double res = calc.Calcular();

            var parametros = new Dictionary<string, object>
            {
                ["Operacao"] = $"{calc.Numero1} {calc.Operacao} {calc.Numero2}",
                ["Resultado"] = res.ToString("F2", CultureInfo.CurrentCulture),
                ["Titulo"] = "Resultado Encantado 🔮"
            };

            await Shell.Current.GoToAsync("resultado", parametros);
        }
        catch (Exception ex)
        {
            LblMsg.Text = $"⚠️ {ex.Message}";
        }
    }
}