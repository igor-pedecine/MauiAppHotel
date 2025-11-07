namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesdoApp;
        public ContratacaoHospedagem() // Constructor
        {   
            InitializeComponent();  
            
            PropriedadesdoApp = (App)Application.Current;

            pck_quarto.ItemsSource = PropriedadesdoApp.Lista_quartos;
            // Definição dos limites para seleção das datas
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(3);
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

        // Evento disparado ao selecionar uma data no DatePicker de check-in
        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_checkin = elemento.Date;

            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(3);
        }
    }
}