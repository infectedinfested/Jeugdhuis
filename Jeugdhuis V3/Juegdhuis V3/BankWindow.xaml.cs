using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Windows.Shapes;

namespace Juegdhuis_V3
{
    /// <summary>
    /// Interaction logic for BankWindow.xaml
    /// </summary>
    public partial class BankWindow : Window
    {
        GeldRepository _geld = new GeldRepository();
        List<Eenheid> Kluis = new List<Eenheid>();
        List<Eenheid> Bank = new List<Eenheid>();
        public BankWindow()
    {
            InitializeComponent();
            _geld.Clr();
            Bank = _geld.toObject();
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
                ListBank.SelectedIndex = temp;
                ListKluis.SelectedIndex = temp;
            }
        }
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (ListBank.SelectedIndex >= 0)
            {
                int temp = ListBank.SelectedIndex;
                remove();
                ListBank.SelectedIndex = temp;
                ListKluis.SelectedIndex = temp;
            }

        }

        private void ListBank_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                int temp = ListKluis.SelectedIndex;
                add();
                ListKluis.SelectedIndex = temp;
                ListBank.SelectedIndex = temp;
            }
            if (e.Key == Key.Left)
            {
                int temp = ListKluis.SelectedIndex;
                remove();
                ListKluis.SelectedIndex = temp;
                ListBank.SelectedIndex = temp;
            }
        }
        private void ListKluis_KeyPressed(object sender, KeyEventArgs e)
        {
            int temp = 0;
            if (e.Key == Key.Right)
            {
                temp = ListKluis.SelectedIndex;
                add();

                ListBank.SelectedIndex = temp;
                ListKluis.SelectedIndex = temp;
            }
            if (e.Key == Key.Left)
            {
                temp = ListKluis.SelectedIndex;
                remove();

                ListBank.SelectedIndex = temp;
                ListKluis.SelectedIndex = temp;
            }
        }


        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            GeldRepository _bank = new GeldRepository();
            _bank.inportAsList(Bank);
            if (_bank.Totaal() != 0)
            {
                string temp = _bank.Totaal() + "";
                string path = "xml/Kluisbladen/" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-reg.txt";
                string text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + ":" + temp + ":Storting" + Environment.NewLine;
                File.AppendAllText(path, text);
                _geld.inportAsList(Kluis);
                _geld.Export("Geld");
                
            }
            Close();
        }

        private void BuildList()
        {
            ListKluis.Items.Clear();
            this.ListBank.Items.Clear();
            foreach (var eenheid in Kluis)
            {
                this.ListKluis.Items.Add(eenheid);
            }
            foreach (var eenheid in Bank)
            {
                this.ListBank.Items.Add(eenheid);
            }
        }
        private void add()
        {
            if (Kluis[ListKluis.SelectedIndex].hoeveel != 0)
            {
                Kluis[ListKluis.SelectedIndex].hoeveel = Kluis[ListKluis.SelectedIndex].hoeveel - 1;
                Bank[ListKluis.SelectedIndex].hoeveel = Bank[ListKluis.SelectedIndex].hoeveel + 1;
                BuildList();
            }
        }
        private void remove()
        {
            if (Bank[ListBank.SelectedIndex].hoeveel != 0)
            {
                Kluis[ListBank.SelectedIndex].hoeveel = Kluis[ListBank.SelectedIndex].hoeveel + 1;
                Bank[ListBank.SelectedIndex].hoeveel = Bank[ListBank.SelectedIndex].hoeveel - 1;
                BuildList();
            }
        }


        private void ListKluis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBank.SelectedIndex = ListKluis.SelectedIndex;

        }

        private void ListBank_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListKluis.SelectedIndex = ListBank.SelectedIndex;
        }


        public delegate void BankWindowEventHandler(object source, EventArgs args);
        public event BankWindowEventHandler BankwindowClosed;

        void BankWindow_Closing(object sender, CancelEventArgs e)
        {
            OnProgramClosed();
        }
        protected virtual void OnProgramClosed()
        {
            BankwindowClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
