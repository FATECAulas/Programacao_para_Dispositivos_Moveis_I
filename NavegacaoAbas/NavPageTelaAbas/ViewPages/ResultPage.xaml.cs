namespace NavPageTelaAbas.ViewPages;

public partial class ResultPage : ContentPage, IQueryAttributable
{
    public ResultPage()
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("Titulo", out var titulo))
            LblTitulo.Text = titulo.ToString();

        if (query.TryGetValue("Operacao", out var op))
            LblOp.Text = op.ToString();

        if (query.TryGetValue("Resultado", out var res))
            LblRes.Text = res.ToString();
    }

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}