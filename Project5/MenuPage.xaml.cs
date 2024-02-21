using System.Net.Http.Json;

namespace Project5;

public class RestaurantMenu
{
	public string name { get; set; } = "";
	public string description { get; set; } = "";
	public string price { get; set; } = "";
}

public partial class MenuPage : ContentPage
{
	public List<RestaurantMenu> myMenu = new List<RestaurantMenu>();
	private string contentUri = "http://localhost/menu.json";
	public MenuPage()
	{
		InitializeComponent();
		CreateMenu();
	}

	private async void CreateMenu()
	{
		var _httpClient = new HttpClient();
		var restaurantMenus = await _httpClient.GetFromJsonAsync<List<RestaurantMenu>>(contentUri);
		restaurantMenus.ForEach(s => myMenu.Add(s));

		foreach (RestaurantMenu menu in myMenu)
		{
			Label newLabel = new Label();
			Label newDesc = new Label();
			newLabel.Text = menu.name + "................................................." + menu.price;
			newDesc.Text = menu.description;

			newLabel.SetDynamicResource(Label.StyleProperty, "MenuLabel");
			newDesc.SetDynamicResource(Label.StyleProperty, "MenuDescLabel");

			newLabel.VerticalOptions = LayoutOptions.Center;
			newDesc.VerticalOptions = LayoutOptions.Center;

            MenuLayout.Add(newLabel);
			MenuLayout.Add(newDesc);
        }
	}
}