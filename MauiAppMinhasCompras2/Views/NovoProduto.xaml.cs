using MauiAppMinhasCompras2.Models;
namespace MauiAppMinhasCompras2.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text),
				Categoria = txt_categoria.Text
			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso", "Registro Inserido", "OK");
			await Navigation.PopAsync();

		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}