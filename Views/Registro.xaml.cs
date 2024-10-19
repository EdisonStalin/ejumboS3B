namespace ejumboS3B.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuarioR.Text;
		string password = txtPasswordR.Text;

		Navigation.PushAsync(new Views.Login(usuario, password));

    }
}