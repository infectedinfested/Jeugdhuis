using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for StockWindow.xaml
    /// </summary>
    public partial class StockWindow : Window
    {
        private DrankRepository _drankenlijst = new DrankRepository();//welke drank er in stock zijn
        public StockWindow()
        {
            InitializeComponent();
            _drankenlijst.ImportDrank();
            foreach (var drank in _drankenlijst.GetDranken())
            {
                this.LBoxDrankOverzicht.Items.Add(drank);
            }
            LblInfoAdd.Content = "Geef in de text vak aan met hoeveel je wat wilt verhogen, "+Environment.NewLine+ "dan druk vink je het vinkje aan en alles wat je dubbel klikt" + Environment.NewLine + "zal zich aanpassen. dubbel klik om dit niet meer te zien.";
        }
        private void LBoxDrankOverzicht_SelectionChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                TxtVanNaar.Text = _drankenlijst.dranken[LBoxDrankOverzicht.SelectedIndex].prijs+"";
                LblNaamDrank.Content = _drankenlijst.dranken[LBoxDrankOverzicht.SelectedIndex].naam;
            }
            catch (Exception)
            {
            }
            
        }
        private void LBoxDrankOverzicht_DoubleClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ChBAdd.IsChecked.Value && !TxtAddAll.Text.Equals(""))
                {
                    _drankenlijst.dranken[LBoxDrankOverzicht.SelectedIndex].prijs = _drankenlijst.dranken[LBoxDrankOverzicht.SelectedIndex].prijs + Double.Parse(TxtAddAll.Text);
                    _drankenlijst.SetDranken(_drankenlijst.dranken);
                    
                }
            }
            catch (Exception)
            {
            }
            updateDrankOverzicht();
        }
        private void BtnEditPrijs_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                _drankenlijst.GetDranken()[LBoxDrankOverzicht.SelectedIndex].sPrijs = "€" + TxtVanNaar.Text;
                _drankenlijst.GetDranken()[LBoxDrankOverzicht.SelectedIndex].prijs = Double.Parse(TxtVanNaar.Text);
                updateDrankOverzicht();
            }
            
        }
        private void StockWindow_Closing(object sender, CancelEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            MessageBox.Show("");
        }














        private void LblInfoAdd_Double(object sender,RoutedEventArgs e)
        {
            LblInfoAdd.Content = "";
        }
        internal void updateDrankOverzicht()
        {
            LBoxDrankOverzicht.Items.Clear();
            foreach (var drank in _drankenlijst.GetDranken())
            {
                this.LBoxDrankOverzicht.Items.Add(drank);
            }
        }
    }
}
