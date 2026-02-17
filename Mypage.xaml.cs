namespace Firstapp;

public partial class Mypage : ContentPage
{
        private Button initbtn()
		{
			Button button = new Button()
			{
				Text = "next",
			};
			button.Clicked += Onchangephoto;
			return button;
		}
        private Image initImage()
		{
			Image image = new Image()
			{
				Name = "photoImage",
				Aspect = Aspect.AspectFit,
				
			};
			return image;
		}
        

	List<String>photos=new List<String>();
	int currentIndex=0;
	public Mypage()
	{
		InitializeComponent();
		photos.Add("aesthetic.jpg");
		photos.Add("autumn.jpg");
		photos.Add("autumnvibe.jpg");
		photos.Add("image1.jpg");
		photos.Add("image2.jpg");
		photoImage.Source=photos[0];
		photoImage.Aspect=Aspect.AspectFit;
	}
	public void Onchangephoto(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		if (button.Text == "next")
		{
			currentIndex+=1;
			if (currentIndex >= photos.Count)
			{
				currentIndex = 0;
			}
		}
		else if (button.Text == "previous")
		{
			currentIndex-=1;
			if (currentIndex < 0)
			{
				currentIndex = photos.Count - 1;
			}
		}
		photoImage.Source = photos[currentIndex];
	}
}