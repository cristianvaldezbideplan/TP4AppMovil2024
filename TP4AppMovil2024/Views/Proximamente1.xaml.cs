namespace TP4AppMovil2024.Views;

public partial class Proximamente1 : ContentPage
{
	public Proximamente1()
	{
		InitializeComponent();
	}
    private void btnPantallaVolver1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PantallaInicio());
    }

}