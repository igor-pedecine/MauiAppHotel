using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    { 
        public List<Quarto> Lista_quartos = new List<Quarto> // Lista de quartos disponível no hotel
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 550.00,
                ValorDiariaCrianca = 280.00
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 295.00,
                ValorDiariaCrianca = 155.00
            },
            new Quarto()
            {
                Descricao = "Suíte Plus",
                ValorDiariaAdulto = 170.00,
                ValorDiariaCrianca = 70.00
            },
            new Quarto()
            {
                Descricao = "Suíte Normal",
                ValorDiariaAdulto = 70.00,
                ValorDiariaCrianca = 35.00
            },
            new Quarto()
            {
                Descricao = "Suíte Eco",
                ValorDiariaAdulto = 35.50,
                ValorDiariaCrianca = 12.50
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {   // medidas padrão da janela do aplicativo
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
