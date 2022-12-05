namespace applicationRencontre;

public partial class LOGIN : ContentPage
{
	public LOGIN()
	{
		InitializeComponent();
    }
	private void Button_Clicked(object sender, EventArgs e)
	{
        if (txtUsername.Text=="admin" && txtPassword.Text == "123")
        {
            Navigation.PushAsync(new HomePage());
        }
        else
        {
            DisplayAlert("Ops ...", "Username or Password is incorrect", "OK");
        }
    }

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
            Navigation.PushAsync(new Register());
    }
}