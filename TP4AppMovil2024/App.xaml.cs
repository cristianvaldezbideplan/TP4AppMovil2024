using TP4AppMovil2024.Views;

namespace TP4AppMovil2024
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            MainPage = new NavigationPage(new PantallaInicio());
        }
    }
}
