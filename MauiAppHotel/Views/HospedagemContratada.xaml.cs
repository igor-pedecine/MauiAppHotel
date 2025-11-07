namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PopAsync(new());

		}
		catch (Exception ex)
		{
			DisplayAlert("Erro", ex.Message, "OK");
		}
	}
}