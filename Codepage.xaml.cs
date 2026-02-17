namespace Firstapp;

public partial class Codepage : ContentPage
{
	public Codepage()
	{
		InitializeComponent();
		VerticalStackLayout stackLayout = initLayout();
		this.Content = stackLayout;
		stackLayout.Add(initImage());
	}
	private Button InitButton()
	{
		Button button = new Button()
		{
			Text = "click me",
			FontSize = 30,
			WidthRequest = 100,
			HeightRequest = 100,
			HorizontalOptions = LayoutOptions.Center
		};
		button.Clicked += button_Clicked;
		return button;
	}
	private void button_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		button.Text = "clicked";
	}
	private Label initLabel()
	{
		Label label = new Label()
		{
			Text = "shalom kita ya",
			FontSize = 45,
			HorizontalOptions = LayoutOptions.Center
		};
		return label;
	}	
	private Image initImage()
	{
		Image image = new Image()
		{
			HeightRequest=185,
			Aspect = Aspect.AspectFit,
			Source="aesthetic.jpg"
		};
		return image;
	}
	private VerticalStackLayout initLayout()
	{
		VerticalStackLayout stackLayout = new VerticalStackLayout()
        {
            BackgroundColor = Colors.LavenderBlush,
			Margin = new Thickness(15,15)
        };
		return stackLayout;
	}

}