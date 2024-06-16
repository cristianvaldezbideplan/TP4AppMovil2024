namespace TP4AppMovil2024.Views;

public partial class PantallaPrincipal : ContentPage
{
	public PantallaPrincipal()
	{
		InitializeComponent();
	}

    private void btnAcercaDeNosotros_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaDeNosotros());
    }

    private void AcercaDelDeveloper_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaDelDeveloper());
    }

    private void btnPantallaProximamente2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Proximamente2());
    }

    private void btnPantallaProximamente3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Proximamente3());
    }
}