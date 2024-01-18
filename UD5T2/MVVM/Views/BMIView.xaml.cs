using UD5T2.MVVM.ViewModels;

namespace UD5T2.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		// Inicializamos los componentes
		InitializeComponent();
		// Establecer el contesto para la vista
		BindingContext = new BMIViewModel();
	}
}