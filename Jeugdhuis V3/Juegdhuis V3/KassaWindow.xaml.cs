using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Juegdhuis_V3
{
    /// <summary>
    /// Interaction logic for KassaWindow.xaml
    /// </summary>
    public partial class KassaWindow : Window
    {
        GeldRepository _geld = new GeldRepository();
        List<Eenheid> Kluis = new List<Eenheid>();
        List<Eenheid> Kassa = new List<Eenheid>();
        public KassaWindow()
        {
            InitializeComponent();
            _geld.Clr();
            Kassa = _geld.toObject();
            _geld.Import("Geld");
            Kluis = _geld.toObject();
            BuildList();
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (ListKluis.SelectedIndex >= 0)
            {
                int temp = ListKluis.SelectedIndex;
                add();
                ListKassa.SelectedIndex = temp;
                ListKluis.SelectedIndex = temp;
            }
        }
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (ListKassa.SelectedIndex >= 0)
            {
                int temp = ListKassa.SelectedIndex;
                remove();
                ListKassa.SelectedIndex = temp;
                ListKluis.SelectedIndex = temp;
            }
        }

        private void ListKassa_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                int temp = ListKluis.SelectedIndex;
                add();
                ListKluis.SelectedIndex = temp;
                ListKassa.SelectedIndex = temp;
            }
            if (e.Key == Key.Left)
            {
                int temp = ListKluis.SelectedIndex;
                remove();
                ListKluis.SelectedIndex = temp;
                ListKassa.SelectedIndex = temp;
            }
        }
        private void ListKluis_KeyPressed(object sender, KeyEventArgs e)
        {
            int temp = 0;
            if (e.Key == Key.Right)
            {
                temp = ListKluis.SelectedIndex;
                add();
                
                ListKassa.SelectedIndex = temp;
                ListKluis.SelectedIndex = temp;
            }
            if (e.Key == Key.Left)
            {
                temp = ListKluis.SelectedIndex;
                remove();
                
                ListKassa.SelectedIndex = temp;
                ListKluis.SelectedIndex = temp;
            }
        }
        

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            //todo: build kassa & kluis
            _geld.inportAsList(Kassa);
            _geld.Export("Kassa");
            _geld.inportAsList(Kluis);
            _geld.Export("Kluis");

            var window = new TappersWindow();
            window.Show();
            Close();
        }

        private void BuildList()
        {
            ListKluis.Items.Clear();
            this.ListKassa.Items.Clear();
            foreach (var eenheid in Kluis)
            {
                this.ListKluis.Items.Add(eenheid);
            }
            foreach (var eenheid in Kassa)
            {
                this.ListKassa.Items.Add(eenheid);
            }
        }
        private void add()
        {
            if (Txtaantal.Text.Any())
            {
                if (Kluis[ListKluis.SelectedIndex].hoeveel >= int.Parse(Txtaantal.Text))
                {
                    Kluis[ListKluis.SelectedIndex].hoeveel = Kluis[ListKluis.SelectedIndex].hoeveel - int.Parse(Txtaantal.Text);
                    Kassa[ListKluis.SelectedIndex].hoeveel = Kassa[ListKluis.SelectedIndex].hoeveel + int.Parse(Txtaantal.Text);
                    BuildList();
                }
            }
            else
            {
                if (Kluis[ListKluis.SelectedIndex].hoeveel != 0)
                {
                    Kluis[ListKluis.SelectedIndex].hoeveel = Kluis[ListKluis.SelectedIndex].hoeveel - 1;
                    Kassa[ListKluis.SelectedIndex].hoeveel = Kassa[ListKluis.SelectedIndex].hoeveel + 1;
                    BuildList();
                }
            }
        }
        private void remove()
        {
            if (Txtaantal.Text.Any())
            {
                if (Kassa[ListKassa.SelectedIndex].hoeveel >= int.Parse(Txtaantal.Text))
                {
                    Kluis[ListKassa.SelectedIndex].hoeveel = Kluis[ListKassa.SelectedIndex].hoeveel + int.Parse(Txtaantal.Text);
                    Kassa[ListKassa.SelectedIndex].hoeveel = Kassa[ListKassa.SelectedIndex].hoeveel - int.Parse(Txtaantal.Text);
                    BuildList();
                }
            }
            else
            {
                if (Kassa[ListKassa.SelectedIndex].hoeveel != 0)
                {
                    Kluis[ListKassa.SelectedIndex].hoeveel = Kluis[ListKassa.SelectedIndex].hoeveel + 1;
                    Kassa[ListKassa.SelectedIndex].hoeveel = Kassa[ListKassa.SelectedIndex].hoeveel - 1;
                    BuildList();
                }
            }
            
        }
        

        private void ListKluis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListKassa.SelectedIndex = ListKluis.SelectedIndex;

        }

        private void ListKassa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListKluis.SelectedIndex = ListKassa.SelectedIndex;
        }

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(text);
        }
    }
}
