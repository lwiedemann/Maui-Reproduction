using Reproduction.Pages;

namespace Reproduction;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ReproductionPage(), true);
    }
}