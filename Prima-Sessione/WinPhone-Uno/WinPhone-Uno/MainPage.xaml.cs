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

// Il modello di elemento per la pagina vuota è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=391641

namespace WinPhone_Uno
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
            // TODO: preparare la pagina da visualizzare qui.

            // TODO: se l'applicazione contiene più pagine, assicurarsi che si stia
            // gestendo il pulsante Indietro dell'hardware effettuando la registrazione per
            // l'evento Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Se si utilizza l'elemento NavigationHelper fornito da alcuni modelli,
            // questo evento viene gestito automaticamente.
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            imgBella.Source = new BitmapImage(new Uri("http://automobili.gear.host/images/Mercedes.jpg"));
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            imgBella.Source = new BitmapImage(new Uri("http://automobili.gear.host/images/Fiat.jpg"));
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            wvBella.Navigate(new Uri("http://www.mercedes-benz.com/en/"));
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            wvBella.Navigate(new Uri("http://www.facebook.com"));
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            mPlayer.Play();
        }
    }
}
