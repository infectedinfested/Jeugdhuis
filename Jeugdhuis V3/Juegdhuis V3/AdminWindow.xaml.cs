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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        List<int> years = new List<int>();
        Dictionary<int, string> months = new Dictionary<int, string>();
        List<JhGeld> eventlist = new List<JhGeld>();
        BankWindow bankwindow = new BankWindow();
        UsersRepository leden = new UsersRepository();

        public AdminWindow()
        {
            InitializeComponent();
            BuildComboBox();
            BuildLedenBox();
            bankwindow.BankwindowClosed += Bankwindow_BankwindowClosed;
        }

        private void Bankwindow_BankwindowClosed(object source, EventArgs args)
        {
            BuildKluisListBox();
        }

        private void CboxMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BuildKluisListBox();
        }

        private void CboxYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BuildKluisListBox();
        }
        internal void BuildComboBox()
        {
            for (int i = 2015; i < DateTime.Now.Year + 1; i++)
            {
                years.Add(i);
            }
            months.Add(1, "Januari");
            months.Add(2, "Februari");
            months.Add(3, "Maart");
            months.Add(4, "April");
            months.Add(5, "Mei");
            months.Add(6, "Juni");
            months.Add(7, "Juli");
            months.Add(8, "Augustus");
            months.Add(9, "September");
            months.Add(10, "Oktober");
            months.Add(11, "November");
            months.Add(12, "December");
            this.CboxMonth.Items.Clear();
            this.CboxYear.Items.Clear();
            foreach (var item in months)
            {
                this.CboxMonth.Items.Add(item.Value);

            }
            foreach (var item in years)
            {
                this.CboxYear.Items.Add(item);
            }
        }
        private void BuildKluisListBox()
        {
            ListBoxMaandOverzicht.Items.Clear();
            eventlist.Clear();
            if (CboxYear.SelectedIndex >= 0 && CboxMonth.SelectedIndex >= 0)
            {
                int tempM = CboxMonth.SelectedIndex + 1;
                int tempY = years[CboxYear.SelectedIndex];

                if (File.Exists("xml/Kluisbladen/" + tempY + "-" + tempM + "-dag.txt"))
                {
                    string[] values;

                    foreach (var item in File.ReadAllLines("xml/Kluisbladen/" + tempY + "-" + tempM + "-dag.txt").ToList())
                    {
                        values = item.Split(':');
                        eventlist.Add(new JhGeld(values[0], values[1], values[2]));
                    }
                    if (File.Exists("xml/Kluisbladen/" + tempY + "-" + tempM + "-reg.txt"))
                    {
                        foreach (var item in File.ReadAllLines("xml/Kluisbladen/" + tempY + "-" + tempM + "-reg.txt").ToList())
                        {
                            values = item.Split(':');
                            eventlist.Add(new JhGeld(values[0], values[1], values[2]));
                        }
                    }
                    eventlist.Sort(delegate (JhGeld c1, JhGeld c2) { return c1.dag.CompareTo(c2.dag); });
                    foreach (var item2 in eventlist)
                    {
                        Console.WriteLine(item2.dag + ":" + item2.begingeld + ":" + item2.eindgeld);
                        ListBoxMaandOverzicht.Items.Add(item2);
                    }
                }
            }

        }
        private void BuildLedenBox()
        {
            LBoxLeden.Items.Clear();
            leden.import();
            foreach (var item in leden.users)
            {
                this.LBoxLeden.Items.Add(item);
            }
        }

        private void BtnStort_Click(object sender, RoutedEventArgs e)
        {
            bankwindow.Show();
            bankwindow.BankwindowClosed += Bankwindow_BankwindowClosed;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            leden.users.Add(new Users(TxtNaam.Text, TxtPass.Text, CbStock.IsChecked.Value, true, false, CbAdmin.IsChecked.Value));
            leden.export();
            BuildLedenBox();
        }
        private void AdminWindow_Closing(object sender, CancelEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}
