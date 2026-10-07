using MauiAppAula4.Mod;
using System.Runtime.Intrinsics.Arm;

namespace MauiAppPilha
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // Soma
        private async void btnSomar_Clicked(object? sender, EventArgs e)
        {
            if (ValidarForm())
            {
                DoisParametro dp = getFormSoma();
                int resultado = dp.Somar();
                string mensagem = $"A soma de {dp.gsN1} + {dp.gsN2} é {resultado}";
                await NewT(mensagem);

                ClearForm();
            }
        }

        // Subtração
        private async void btnSubtrair_Clicked(object? sender, EventArgs e)
        {
            if (ValidarForm())
            {
                Subtracao sub = getFormSubtracao();
                int resultado = sub.Subtrair();
                string mensagem = $"A subtração de {sub.gsN1} - {sub.gsN2} é {resultado}";
                await NewT(mensagem);
                ClearForm();
            }
        }

        // Multiplicação
        private async void btnMultiplicar_Clicked(object? sender, EventArgs e)
        {
            if (ValidarForm())
            {
                Multiplicacao mult = getFormMultiplicacao();
                int resultado = mult.Multiplicar();
                string mensagem = $"A multiplicação de {mult.gsN1} * {mult.gsN2} é {resultado}";
                await NewT(mensagem);
                ClearForm();
            }
        }

        // Divisão
        private async void btnDividir_Clicked(object? sender, EventArgs e)
        {
            if (ValidarForm())
            {
                Divisao div = getFormDivisao();
                int resultado = div.Dividir();
                string mensagem = $"A divisão de {div.gsN1} / {div.gsN2} é {resultado}";
                await NewT(mensagem);
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
            txtNum1.Focus();
        }

        private DoisParametro getFormSoma()
        {
            DoisParametro dp = new DoisParametro();
            dp.gsN1 = Convert.ToInt32(txtNum1.Text);
            dp.gsN2 = Convert.ToInt32(txtNum2.Text);
            return dp;
        }

        private Subtracao getFormSubtracao()
        {
            Subtracao sub = new Subtracao();
            sub.gsN1 = Convert.ToInt32(txtNum1.Text);
            sub.gsN2 = Convert.ToInt32(txtNum2.Text);
            return sub;
        }

        private Multiplicacao getFormMultiplicacao()
        {
            Multiplicacao mult = new Multiplicacao();
            mult.gsN1 = Convert.ToInt32(txtNum1.Text);
            mult.gsN2 = Convert.ToInt32(txtNum2.Text);
            return mult;
        }

        private Divisao getFormDivisao()
        {
            Divisao div = new Divisao();
            div.gsN1 = Convert.ToInt32(txtNum1.Text);
            div.gsN2 = Convert.ToInt32(txtNum2.Text);
            return div;
        }


        private void setForm(DoisParametro dp)
        {
            int resultado = dp.Somar();
            lblRes.Text = $"A soma de {dp.gsN1} + {dp.gsN2} = {resultado}";
        }

        private void setForm(Subtracao dp)
        {
            int resultado = dp.Subtrair();
            lblRes.Text = $"A subtração de {dp.gsN1} - {dp.gsN2} = {resultado}";
        }

        private void setForm(Multiplicacao dp)
        {
            int resultado = dp.Multiplicar();
            lblRes.Text = $"A multiplicação de {dp.gsN1} * {dp.gsN2} = {resultado}";
        }

        private void setForm(Divisao dp)
        {
            int resultado = dp.Dividir();
            lblRes.Text = $"A divisão de {dp.gsN1} / {dp.gsN2} = {resultado}";
        }


        #region NewForm/Tela
        private async Task NewT(string mensagem)
        {
            await Navigation.PushAsync(new ResultPage(mensagem));
        }
        #endregion

        private bool ValidarForm()
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || !int.TryParse(txtNum1.Text, out _))
            {
                lblRes.Text = "Digite um número válido no Campo 1";
                txtNum1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNum2.Text) || !int.TryParse(txtNum2.Text, out _))
            {
                lblRes.Text = "Digite um número válido no Campo 2";
                txtNum2.Focus();
                return false;
            }

            lblRes.Text = string.Empty;
            return true;
        }
    }
}