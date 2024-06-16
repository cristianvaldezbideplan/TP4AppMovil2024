namespace TP4AppMovil2024.Views;

public partial class Proximamente3 : ContentPage
{
	public Proximamente3()
	{
		InitializeComponent();
	}

    private void btnPantallaVolver3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PantallaPrincipal());
    }
}