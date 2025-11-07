namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesdoApp;
        public ContratacaoHospedagem()
        {
            InitializeComponent();

            PropriedadesdoApp = (App)Application.Current;

            pck_quarto.ItemsSource = PropriedadesdoApp.Lista_quartos;
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        
        {
            await Navigation.PushAsync(new Sobre());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new HospedagemContratada());
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}