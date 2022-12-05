namespace applicationRencontre;
public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }


    private void ImageButton_SizeChanged(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage());

    }

    private void ImageButton_SizeChanged_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new messagerie());
    }

    private void ImageButton_SizeChanged_2(object sender, EventArgs e) 
    {
        
    }

    private void ImageButton_SizeChanged_3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new profil());
    }

    private void ImageButton_SizeChanged_4(object sender, EventArgs e)
    {

    }
}