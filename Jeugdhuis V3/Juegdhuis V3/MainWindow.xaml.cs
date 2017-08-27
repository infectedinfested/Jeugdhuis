using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;


namespace Juegdhuis_V3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersRepository gebruikers = new UsersRepository();
        GeldRepository kassa = new GeldRepository();
        Boolean late = false;

        public MainWindow()
        {
            InitializeComponent();
            gebruikers.import();
        }

        private void Btnlogin_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(TxtLogin2.Text);
            if (gebruikers.getUser(TxtLogin1.Text, TxtWachtwoord1.Password) != null)
            { 

                TxtLogin1.IsEnabled = false;
                TxtWachtwoord1.IsEnabled = false;
                Btnvroege.IsEnabled = true;
                Btnlate.IsEnabled = true;
                CheckUser(TxtLogin1.Text, TxtWachtwoord1.Password);
                if (!TxtLogin2.Text.Equals(""))
                {
                    if (gebruikers.getUser(TxtLogin2.Text, TxtWachtwoord2.Password) != null)
                    {
                        TxtLogin2.IsEnabled = false;
                        TxtWachtwoord2.IsEnabled = false;
                        CheckUser(TxtLogin2.Text, TxtWachtwoord2.Password);
                    }
                    else
                    {
                        TxtLogin2.Clear();
                        TxtWachtwoord2.Clear();
                        MessageBox.Show("Fout wachtwoord");
                    }
                }  
            }
            else
            {
                TxtLogin1.Clear();
                TxtWachtwoord1.Clear();
                TxtLogin2.Clear();
                TxtWachtwoord2.Clear();
                MessageBox.Show("Fout wachtwoord");
            }     
        }

        private void BtnTappers_Click(object sender, RoutedEventArgs e)
        {
            string tijd = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            string shift;
            if (late==true)
            {
                shift = "late";
            }
            else
            {
                shift = "vroege";
            }
            Jhdag nu = new Jhdag(TxtLogin1.Text, TxtLogin2.Text, "", DateTime.ParseExact(tijd, "d/M/yyyy", CultureInfo.InvariantCulture), shift);
            RegTappers(nu);
            RegKluis(nu);
            var window = new KassaWindow();
            window.Show();
            Close();
        }
        private void BtnKluis_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("under construction");
        }
        private void BtnStock_Click(object sender, RoutedEventArgs e)
        {
            var window = new StockWindow();
            window.Show();
            Close();
        }
        private void BtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            var window = new AdminWindow();
            window.Show();
            Close();
        }
        private void Btnvroege_Click(object sender, RoutedEventArgs e)
        {
            Btnvroege.IsEnabled = false;
            Btnlate.IsEnabled = true;
            late = false;
            BtnTappers.IsEnabled = true;
        }

        private void Btnlate_Click(object sender, RoutedEventArgs e)
        {
            Btnvroege.IsEnabled = true;
            Btnlate.IsEnabled = false;
            late = true;
            BtnTappers.IsEnabled = true;
        }




        private void CheckUser(string naam, string wachtwoord)
        {
            List<bool> toegang = gebruikers.getUser(naam,wachtwoord);
            if (toegang[0])
            {
                BtnStock.IsEnabled = true;
            }
            if (toegang[2])
            {
                BtnKluis.IsEnabled = true;
            }
            if (toegang[3])
            {
                BtnAdmin.IsEnabled = true;
            }

        }

        private void RegTappers(Jhdag input)
        {

            string invoer = input.naam1 + ":" + input.naam2 + ":" + input.naam3 + ":" + input.DatumToString() + ":" + input.shift;
            if (!input.equals(new Jhdag(File.ReadLines("xml/TappersLijst.txt").Last())))
            {
                List<string> newLines = new List<string>();
                newLines.Add(invoer);
                File.AppendAllLines("xml/TappersLijst.txt", newLines);
            }
        }
        private void RegKluis(Jhdag input)
        {
            kassa.Import("Geld");
            string totaal = kassa.Totaal() + "";            
            if (File.Exists("xml/Kluisbladen/" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + "dagTemp.txt"))
            {
                string values = File.ReadLines("xml/Kluisbladen/" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + "dagTemp.txt").Last();
                string[] value = values.Split(':');
                if (!value[0].Equals(input.DatumToString()))
                {
                    File.AppendAllText("xml/KluisTemp.txt", input.DatumToString() + ":" + totaal + ":null" + Environment.NewLine);
                }
            }
            else
            {
                File.AppendAllText("xml/Kluisbladen/" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + "dagTemp.txt", input.DatumToString() + ":" + totaal + ":null" + Environment.NewLine);
            }
        }

    }
}
