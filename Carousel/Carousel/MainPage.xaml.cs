using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();

            var redContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Red",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center,
                        },
                        new BoxView
                        {
                            Color= Color.Red,
                            WidthRequest= 200,
                            HeightRequest= 200,
                            HorizontalOptions= LayoutOptions.Center,
                            VerticalOptions= LayoutOptions.CenterAndExpand,  
                        }
                    }
                }
            };
            var greenContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Green",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center,
                        },
                        new BoxView
                        {
                            Color= Color.Green,
                            WidthRequest= 200,
                            HeightRequest= 200,
                            HorizontalOptions= LayoutOptions.Center,
                            VerticalOptions= LayoutOptions.CenterAndExpand,
                        }
                    }
                }
            };
            var blueContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Blue",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center,
                        },
                        new BoxView
                        {
                            Color= Color.Blue,
                            WidthRequest= 200,
                            HeightRequest= 200,
                            HorizontalOptions= LayoutOptions.Center,
                            VerticalOptions= LayoutOptions.CenterAndExpand,
                        }
                    }
                }
            };

            Children.Add(greenContentPage);
            Children.Add(blueContentPage);
            Children.Add(redContentPage);
        }
    }
}
