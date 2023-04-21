using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {
        Dictionary<string, string> sonad = new Dictionary<string, string>();
        Label sonaLabel;
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        FileInfo file;
        public MainPage()
        {
            InitializeComponent();
            sonad.Add("Koer", "Собака");
            sonad.Add("Kass", "Кошка");
            
            //Directory.CreateDirectory(folderPath);
            //File.Create(folderPath);

            int count = 0;
            foreach (var sona in sonad.Keys)
            {
                count++;
                var sonaPage = new ContentPage
                {
                    Content = new StackLayout
                    {
                        Children=
                        {
                            new Label
                            {
                                TabIndex= count,
                                Text = sona,
                                FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                                VerticalOptions= LayoutOptions.Start,
                                HorizontalOptions = LayoutOptions.Center,
                            }
                        }
                    },
                };
                Children.Add(sonaPage);
            }

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

            //Children.Add(greenContentPage);
            //Children.Add(blueContentPage);
            //Children.Add(redContentPage);
        }
    }
}
