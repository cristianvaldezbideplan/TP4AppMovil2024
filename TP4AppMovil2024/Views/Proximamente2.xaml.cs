namespace TP4AppMovil2024.Views;

public partial class Proximamente2 : ContentPage
{
	public Proximamente2()
	{
		InitializeComponent();
	}

    private void btnPantallaVolver2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PantallaPrincipal());
    }
}