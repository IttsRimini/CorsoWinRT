using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;
using Newtonsoft;
using Newtonsoft.Json;

// Il modello di elemento per la pagina vuota è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=391641

namespace WinPhoneQuinte
{
    /// <summary>
    /// Pagina vuota che può essere utilizzata autonomamente oppure esplorata all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Richiamato quando la pagina sta per essere visualizzata in un Frame.
        /// </summary>
        /// <param name="e">Dati dell'evento in cui vengono descritte le modalità con cui la pagina è stata raggiunta.
        /// Questo parametro viene in genere utilizzato per configurare la pagina.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgBella.Source = new BitmapImage(new Uri("http://automobili.gear.host/images/Fiat.jpg"));
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            wvBello.Navigate(new Uri("http://www.google.com"));
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            mediaBello.Play();
        }

        private async void Button_Click3(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            string valore = await client.GetStringAsync(new Uri("http://automobili.gear.host/api/auto"));

            List<Automobile> automobili = JsonConvert.DeserializeObject<List<Automobile>>(valore);
            lvDati.ItemsSource = automobili;
        }

        private async void Button_Click4(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            string valore = await client.GetStringAsync(new Uri("http://graph.facebook.com/" + edtProfilo.Text));

            FBClass oggettoFB = JsonConvert.DeserializeObject<FBClass>(valore);
            lblProfilo.Text = oggettoFB.name;
            imgProfilo.Source = new BitmapImage(new Uri(oggettoFB.cover.source));
        }
    }

    class Automobile
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
    }

    public class CategoryList
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Cover
    {
        public long cover_id { get; set; }
        public int offset_x { get; set; }
        public int offset_y { get; set; }
        public string source { get; set; }
        public string id { get; set; }
    }

    public class Location
    {
        public string city { get; set; }
        public string country { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
    }

    public class Parking
    {
        public int lot { get; set; }
        public int street { get; set; }
        public int valet { get; set; }
    }

    public class FBClass
    {
        public string id { get; set; }
        public string about { get; set; }
        public bool can_post { get; set; }
        public string category { get; set; }
        public List<CategoryList> category_list { get; set; }
        public int checkins { get; set; }
        public string company_overview { get; set; }
        public Cover cover { get; set; }
        public string description { get; set; }
        public string founded { get; set; }
        public string general_info { get; set; }
        public bool has_added_app { get; set; }
        public bool is_community_page { get; set; }
        public bool is_published { get; set; }
        public int likes { get; set; }
        public string link { get; set; }
        public Location location { get; set; }
        public string mission { get; set; }
        public string name { get; set; }
        public Parking parking { get; set; }
        public int talking_about_count { get; set; }
        public string username { get; set; }
        public string website { get; set; }
        public int were_here_count { get; set; }
    }
}
