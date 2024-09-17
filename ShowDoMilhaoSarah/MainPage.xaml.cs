using Microsoft.Maui.Controls;

namespace ShowDoMilhaoSarah
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void JogarClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
    	Application.Current.MainPage = new Perguntas();
        }
    }
}