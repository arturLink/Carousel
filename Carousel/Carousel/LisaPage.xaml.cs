using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LisaPage : ContentPage
    {
        Editor estSona, veneSona;
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "sonad.txt";
        public LisaPage()
        {
            StackLayout st = new StackLayout();
            Content = st;
            estSona = new Editor()
            {
                Placeholder = "Eesti sõna"
            };

            veneSona = new Editor()
            {
                Placeholder = "Vene sõna"
            };

            Button lisa = new Button()
            {
                Text = "Lisa sõna"
            };
            lisa.Clicked += Lisa_Clicked;

            Button tagas = new Button()
            {
                Text = "Tagasi"
            };
            tagas.Clicked += Tagas_Clicked;

            st.Children.Add(estSona);
            st.Children.Add(veneSona);
            st.Children.Add(lisa);
            st.Children.Add(tagas);
        }

        private void Lisa_Clicked(object sender, EventArgs e)
        {
            string uusSona = estSona.Text + "-" + veneSona.Text + ";";
            File.AppendAllText(folderPath, uusSona);
            estSona.Text = null;
            veneSona.Text = null;
        }

        private async void Tagas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}