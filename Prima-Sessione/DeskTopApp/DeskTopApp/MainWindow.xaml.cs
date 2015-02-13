using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace DeskTopApp
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Libro> LibriOC;

        public MainWindow()
        {
            InitializeComponent();
            LibriOC = new ObservableCollection<Libro>();

            dgDati.ItemsSource = LibriOC;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Libro l1 = new Libro { Id = 1, Autore = "Belluzzi", Titolo = "Istituto Tecnico Tecnologico" };
            LibriOC.Add(l1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Libro l1 = new Libro { Id = 1, Autore = "Da Vinci", Titolo = "Istituto Tecnico Tecnologico" };
            LibriOC.Add(l1);
        }
    }

    class Libro 
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public String Autore { get; set; }
    }

}
