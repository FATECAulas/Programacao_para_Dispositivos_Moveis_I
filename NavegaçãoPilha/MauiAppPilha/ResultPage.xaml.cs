using System.Runtime.Intrinsics.Arm;

namespace MauiAppPilha;

public partial class ResultPage : ContentPage
{
	public ResultPage(string mensagem)
	{
		InitializeComponent();
        LblResult.Text = mensagem;
    }
    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void SetFrom(double resCalc)
	{
		LblResult.Text = resCalc.ToString();
    }
}