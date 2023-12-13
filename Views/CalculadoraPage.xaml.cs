using MICALCULADORA.ViewModel;

namespace MICALCULADORA.Views;

public partial class CalculadoraPage : ContentPage
{
	public CalculadoraPage(CalculadoraPageViewModel calculadoraPageViewModel)
	{
		InitializeComponent();
		BindingContext = calculadoraPageViewModel;
	}
}