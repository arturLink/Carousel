using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {
        string sonad = "Koer-Собака;Kass-Кошка;Auto-Машина;";
        Label sonaLabel;
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+"sonad.txt";
        FileInfo file;
        string[] fileSonad;
        string[] estSonad;
        public MainPage()
        {
            InitializeComponent();

            //File.WriteAllText(folderPath, sonad);

            string fileKoik = File.ReadAllText(folderPath);
            fileSonad = fileKoik.Split(';');

            for (int i = 0; i < fileSonad.Length; i++)
            {
                string rnd = fileSonad[i];
                estSonad = rnd.Split('-');
                var Page = new ContentPage
                {
                    Content = new StackLayout
                    {
                        TabIndex = i,
                        Children =
                        {
                            new Label
                            {
                                FontSize= 20,
                                Text = estSonad[0],
                                BackgroundColor= Color.LightGray,
                                TextColor = Color.Black,
                                TabIndex= i
                            },
                            new Button
                            {
                                Text = "Lisa uus sõna"
                            }
                        }
                    }
                };
                Children.Add(Page);
                var lbl = ((StackLayout)Page.Content).Children[0] as Label;
                var tap = new TapGestureRecognizer();
                lbl.GestureRecognizers.Add(tap);
                tap.Tapped += Tap_Tapped; ;
                var btn = ((StackLayout)Page.Content).Children[1] as Button;
                btn.Clicked += Btn_Clicked;
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

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LisaPage());
        }

        bool OnOff = true;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            if (OnOff)
            {
                var lbl = sender as Label;
                string Tekst_on = fileSonad[lbl.TabIndex];
                estSonad = Tekst_on.Split('-');
                lbl.Text += " - " + estSonad[1];
                OnOff = false;
            }
            else
            {
                var lbl = sender as Label;
                string Tekst_on = fileSonad[lbl.TabIndex];
                estSonad = Tekst_on.Split('-');
                lbl.Text = estSonad[0];
                OnOff = true;
            }
        }
    }
}
