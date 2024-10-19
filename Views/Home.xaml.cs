namespace ejumboS3B.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
    }
    public Home(string user)
    {
        InitializeComponent();
        lblSaludo.Text = "Bienvenido: "+user;
    }
}