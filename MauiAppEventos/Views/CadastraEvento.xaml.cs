using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastraEvento : ContentPage
{
    public CadastraEvento()
    {
        InitializeComponent();
        Dtpck_Inicio.MinimumDate = DateTime.Now;
        Dtpck_Inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        Dtpck_Termino.MinimumDate = Dtpck_Inicio.Date.AddDays(1);
        Dtpck_Termino.MaximumDate = Dtpck_Inicio.Date.AddMonths(6);
    }

    private void Dtpck_Inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_checkin = elemento.Date;
        Dtpck_Termino.MinimumDate = data_selecionada_checkin.Date.AddDays(1);
        Dtpck_Termino.MaximumDate = data_selecionada_checkin.Date.AddMonths(6);
    }

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Evento evento = new()
            {
                NomeEvento = NomeEvento.Text,
                LocalEvento = LocalEvento.Text,
                Participantes = Convert.ToInt32(stp_numParticipantes.Value),
                ValorParticipante = Convert.ToDouble(CustoParticipante.Text),
                DataInicio = Dtpck_Inicio.Date,
                DataFim = Dtpck_Termino.Date
            };
            await Navigation.PushAsync(new EventoCriado()
            {
                BindingContext = evento
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("ops", ex.Message, "OK");

        }
    }
}