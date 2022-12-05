namespace applicationRencontre;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (ConfirmPassword.Text== txtPassword.Text && ConfirmPassword.Text is not null)
        {
            Navigation.PushAsync(new LOGIN());
        }
        else
        {
            DisplayAlert("Ops ...", "Username or Password is incorrect", "recommencer");
        }
    }
}