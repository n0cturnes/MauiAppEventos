namespace MauiAppEventos.Views;

public partial class EventoCriado : ContentPage
{
    public EventoCriado()
    {
        InitializeComponent();
    }

    private void Voltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }
    }
}