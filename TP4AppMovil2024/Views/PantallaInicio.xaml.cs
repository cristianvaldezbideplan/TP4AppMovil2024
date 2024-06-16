namespace TP4AppMovil2024.Views;

public partial class PantallaInicio : ContentPage
{
	public PantallaInicio()
	{
		InitializeComponent();
	}

    private void btnPantallaInicio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PantallaPrincipal());
    }

    private void btnPantallaProximamente1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Proximamente1());
    }
}