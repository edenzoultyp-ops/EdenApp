using EdenApp.Helpers;
using EdenApp.Services;
using EdenApp.ViewModels;

namespace EdenApp.Views;

public partial class SignInPage : ContentPage
{
    public SignInPage()
	{
		InitializeComponent();
        BindingContext = new SignInViewModel();   
    }  
}