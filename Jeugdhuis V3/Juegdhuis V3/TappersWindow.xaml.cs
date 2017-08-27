using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Juegdhuis_V3
{
    /// <summary>
    /// Interaction logic for TappersWindow.xaml
    /// </summary>
    public partial class TappersWindow : Window
    {
        private GeldRepository _kassa = new GeldRepository();  //hoeveel er is de kassa zit
        private GeldRepository _wissel = new GeldRepository(); //hoeveel er gewisseld moet worden
        private GeldRepository _bestelling = new GeldRepository();//hoeveel er besteld wordt
        private GeldRepository _Kluis = new GeldRepository(); // hoeveel er in de kluis zit.
        private List<String> _last = new List<String>();
        private Dictionary<string, int> _kassaText = new Dictionary<string, int>();//effectief hoeveelheden geld dat verricht wordt
        private List<Drank> _bestellingText = new List<Drank>(); //effectieve hoeveelheden drank dat besteld is
        private DrankRepository _drankenlijst = new DrankRepository();//welke drank er in stock zijn
        //private KluisRepository kluis = new KluisRepository();
        public TappersWindow()
        {
            //BrushConverter bc = new BrushConverter();
            //LBoxBestelling.Background = (Brush)bc.ConvertFrom("#777777");

            _Kluis.Import("Kluis");
            InitializeComponent();
            _kassa.Import("Kassa");
            foreach (var eenheid in _kassa.toObject())
            {
                this.LBoxKassaInhoud.Items.Add(eenheid);

            }
            _drankenlijst.ImportDrank();
            foreach (var drank in _drankenlijst.GetDranken())
            {
                this.LBoxDrankOverzicht.Items.Add(drank);

            }
            LBoxTerugGave.Visibility = Visibility.Hidden;
            if (_drankenlijst.GetDranken().Count > 16)
            {
                for (int i = 16; i < _drankenlijst.GetDranken().Count; i++)
                {
                    this.addDrankKnop(_drankenlijst.GetDranken()[i],i-15);
                }    
            }
        }



        private void Button500_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro500++;
            _last.Add("€500");
            foreach (var cash in _kassaText)
            {
                if(cash.Key.Equals("€500"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€500",1);
            UpdateKassa();
        }

        private void Button200_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro200++;
            _last.Add("€200");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€200"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€200", 1);
            UpdateKassa();
        }

        private void Button100_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro100++;
            _last.Add("€100");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€100"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€100", 1);
            UpdateKassa();
        }
        private void Button50_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro50++;
            _last.Add("€50");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€50"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€50", 1);
            UpdateKassa();
        }

        private void Button20_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro20++;
            _last.Add("€20");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€20"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€20", 1);
            UpdateKassa();
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro10++;
            _last.Add("€10");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€10"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€10", 1);
            UpdateKassa();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro5++;
            _last.Add("€5");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€5"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€5", 1);
            UpdateKassa();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro2++;
            _last.Add("€2");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€2"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€2", 1);
            UpdateKassa();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro1++;
            _last.Add("€1");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€1"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€1", 1);
            UpdateKassa();
        }

        private void Button050_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro050++;
            _last.Add("€0,50");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€0,50"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€0,50", 1);
            UpdateKassa();
        }

        private void Button020_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro020++;
            _last.Add("€0,20");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€0,20"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€0,20", 1);
            UpdateKassa();
        }

        private void Button010_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro010++;
            _last.Add("€0,10");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€0,10"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€0,10", 1);
            UpdateKassa();
        }

        private void Button005_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro005++;
            _last.Add("€0,05");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€0,05"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€0,05", 1);
            UpdateKassa();
        }

        private void Button002_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro002++;
            _last.Add("€0,02");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€0,02"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€0,02", 1);
            UpdateKassa();
        }

        private void Button001_Click(object sender, RoutedEventArgs e)
        {
            _wissel.euro001++;
            _last.Add("€0,01");
            foreach (var cash in _kassaText)
            {
                if (cash.Key.Equals("€0,01"))
                {
                    _kassaText[cash.Key]++;
                    UpdateKassa();
                    return;
                }
            }
            _kassaText.Add("€0,01", 1);
            UpdateKassa();
        }
        private void Buttonclr_Click(object sender, RoutedEventArgs e)
        {
            _wissel.Clr();
            Lboxwissel.Items.Clear();
            LblWisselgeld.Content = _wissel.Totaal();
            _last.Clear();
            _kassaText.Clear();
            //MakeLblKassaTerug();
            LblKassaTerug.Content = "";
            UpdateKassa();
            LBoxTerugGave.Items.Clear();
            LBoxKassaInhoud.Visibility = Visibility.Visible;
            LBoxTerugGave.Visibility = Visibility.Hidden;     
        }

        

        private void Buttondel_Click(object sender, RoutedEventArgs e)
        {
            if (_last.Count <= 0) return;
            foreach (var item in _kassaText)
            {
                if (item.Key.Equals(_last[_last.Count - 1]))
                {
                    var temp1 = item.Value;
                    var temp2 = item.Key;
                    if (item.Value>1)
                    {
                        _kassaText.Remove(temp2);
                        _kassaText.Add(temp2, temp1-1);
                        break;
                    }
                    else
                    {
                        _kassaText.Remove(temp2);
                        break;
                    }
                }
            }
            _wissel.RemoveLast(_last[_last.Count - 1]);
            _last.RemoveAt(_last.Count - 1);
            LblWisselgeld.Content = _wissel.Totaal();
            UpdateKassa();
        }
        private void ButtonAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            if (_bestellingText.Any() && _wissel.Totaal() - MakeBestelPrijs() >= 0)
            {
                _kassa.afTrekken(_kassa.BerekenTeruggave(_wissel.Totaal() - MakeBestelPrijs()));
                _kassa.optellenKassa(_kassaText);
                _kassa.Export("Kassa");
                _kassa.Import("Kassa");
                //_drankenlijst veranderd door _bestellingtext
                _drankenlijst.SetDranken(_drankenlijst.VerwerkBestelling(_bestellingText));
                _drankenlijst.ExportDrank();
                LBoxDrankOverzicht.Items.Clear();
                foreach (var drank in _drankenlijst.GetDranken())
                {
                    this.LBoxDrankOverzicht.Items.Add(drank);

                }
                LBoxKassaInhoud.Items.Clear();
                foreach (var eenheid in _kassa.toObject())
                {
                    this.LBoxKassaInhoud.Items.Add(eenheid);

                }
                _wissel.Clr();
                Lboxwissel.Items.Clear();
                LblWisselgeld.Content = _wissel.Totaal();
                _last.Clear();
                _kassaText.Clear();
                LblKassaTerug.Content = "";
                UpdateKassa();
                LBoxTerugGave.Items.Clear();
                LBoxKassaInhoud.Visibility = Visibility.Visible;
                LBoxTerugGave.Visibility = Visibility.Hidden;
                _bestellingText.Clear();
                UpdateBestelling();
                LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());
                MakeLblKassaTerug();
            }
            else
            {
                MessageBox.Show("ongeldige verwerking");
            }

        }
        private void BtnZuipkaart_Click(object sender, RoutedEventArgs e)
        {
            if (_bestellingText.Any())
            {
                _drankenlijst.SetDranken(_drankenlijst.VerwerkBestelling(_bestellingText));
                _drankenlijst.ExportDrank();
                LBoxDrankOverzicht.Items.Clear();
                foreach (var drank in _drankenlijst.GetDranken())
                {
                    this.LBoxDrankOverzicht.Items.Add(drank);

                }
                _wissel.Clr();
                Lboxwissel.Items.Clear();
                LblWisselgeld.Content = _wissel.Totaal();
                _last.Clear();
                _kassaText.Clear();
                LblKassaTerug.Content = "";
                UpdateKassa();
                LBoxTerugGave.Items.Clear();
                LBoxKassaInhoud.Visibility = Visibility.Visible;
                LBoxTerugGave.Visibility = Visibility.Hidden;
                _bestellingText.Clear();
                UpdateBestelling();
                LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());
                MakeLblKassaTerug();
            }
            else
            {
                MessageBox.Show("ongeldige verwerking");
            }
        }
        private void BtnAddGeld_Click(object sender, RoutedEventArgs e)
        {
            if (_kassaText.Any())
            {
                //_kassa.afTrekken(_kassa.BerekenTeruggave(_wissel.Totaal() - MakeBestelPrijs()));
                _kassa.optellenKassa(_kassaText);
                _kassa.Export("Kassa");
                _kassa.Import("Kassa");

                LBoxKassaInhoud.Items.Clear();
                foreach (var eenheid in _kassa.toObject())
                {
                    this.LBoxKassaInhoud.Items.Add(eenheid);

                }
                _wissel.Clr();
                Lboxwissel.Items.Clear();
                LblWisselgeld.Content = _wissel.Totaal();
                _last.Clear();
                _kassaText.Clear();
                LblKassaTerug.Content = "";
                UpdateKassa();
                LBoxTerugGave.Items.Clear();
                LBoxKassaInhoud.Visibility = Visibility.Visible;
                LBoxTerugGave.Visibility = Visibility.Hidden;
                _bestellingText.Clear();
                UpdateBestelling();
                LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());
                MakeLblKassaTerug();
            }
            else
            {
                MessageBox.Show("ongeldige verwerking");
            }

        }
        private void UpdateKassa()
        {
            
            LblWisselgeld.Content = String.Format("{0:C2}", _wissel.Totaal());         
            Lboxwissel.Items.Clear();          
            MakeLblKassaTerug();           
            foreach (var text in _kassaText)
            {
                Lboxwissel.Items.Add(text.Key + "   " + text.Value);
            }          

        }

        private void MakeLblKassaTerug()
        {
            LblKassaTerug.Content = String.Format("{0:C2}", _wissel.Totaal() - MakeBestelPrijs());
            if (_kassa.BerekenTeruggave(_wissel.Totaal() - MakeBestelPrijs()) != null)
            {
                LBoxTerugGave.Items.Clear();
                
                LBoxKassaInhoud.Visibility = Visibility.Hidden;
                LBoxTerugGave.Visibility = Visibility.Visible;

                foreach (var item in _kassa.BerekenTeruggave(_wissel.Totaal() - MakeBestelPrijs()))
                {
                    LBoxTerugGave.Items.Add(item);
                }
            }
            //else
            //{
            //    MessageBox.Show("Er zijn niet genoeg briefjes");
            //}
        }
















        private void BtnDrankDel_Click(object sender, RoutedEventArgs e)
        {
            _bestellingText.Clear();
            UpdateBestelling();
            LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());

            _wissel.Clr();
            Lboxwissel.Items.Clear();
            LblWisselgeld.Content = _wissel.Totaal();
            _last.Clear();
            _kassaText.Clear();
            MakeLblKassaTerug();
            UpdateKassa();
            LBoxTerugGave.Items.Clear();
            LBoxKassaInhoud.Visibility = Visibility.Visible;
            LBoxTerugGave.Visibility = Visibility.Hidden;
        }

        private void UpdateBestelling()
        {

            LBoxBestelling.Items.Clear();
            foreach (var text in _bestellingText)
            {
                LBoxBestelling.Items.Add(text.naam + "   " + text.hoeveel + "   " +
                                         String.Format("{0:C2}", text.prijs));
            }
            LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());
        }

        private double MakeBestelPrijs()
        {
            double tot = 0.00;
            foreach (var drank in _bestellingText)
            {
                tot = tot + drank.prijs;
            }
            LblBestelPrijs.Content = String.Format("{0:C2}", tot);
            return tot;
        }







        private void updateDrank(string naam)
        {
            foreach (var drank in _bestellingText)
            {
                if (drank.naam.Equals(naam))
                {
                    if (_drankenlijst.getHoeveel(naam)-drank.hoeveel > 0)
                    {

                        drank.hoeveel++;
                        drank.prijs = drank.prijs + _drankenlijst.getPrijs(naam); 
                        UpdateBestelling();
                        LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());
                       
                    }
                    return;
                    
                }
            }
            if (_drankenlijst.getHoeveel(naam) > 0)
            {
                _bestellingText.Add(new Drank(naam, 1, _drankenlijst.getPrijs(naam)));
                UpdateBestelling();
            }
               
        }
        private void BtnZuip_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Zuipkaart";
            foreach (var drank in _bestellingText)
            {
                if (drank.naam.Equals(naam))
                {
                    drank.hoeveel++;
                    drank.prijs = drank.prijs + 5.00; 
                    UpdateBestelling();
                    LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());
                    return;
                }
            }
            _bestellingText.Add(new Drank("Zuipkaart", 1, 5.00));
            UpdateBestelling();
        }
        private void Btnbier_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Bier";
            updateDrank(naam);
        }
        private void BtnCola_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Cola";
            updateDrank(naam);
        }
        private void BtnCZero_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Cola Zero";
            updateDrank(naam);
        }
        private void BtnFanta_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Fanta";
            updateDrank(naam);
        }

        private void BtnSpite_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Sprite";
            updateDrank(naam);
        }

        private void BtnPWater_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Plat Water";
            updateDrank(naam);
        }

        private void BtnWssl_Click(object sender, RoutedEventArgs e)
        {
            if (_kassa.euro1 >= 2)
            {
                _kassa.euro1 = _kassa.euro1 - 2;
                _kassa.euro2++;
                _kassa.Export("Kassa");
                _kassa.Import("Kassa");
                UpdateKassa();
                LBoxKassaInhoud.Items.Clear();
                foreach (var eenheid in _kassa.toObject())
                {
                    this.LBoxKassaInhoud.Items.Add(eenheid);

                }
            }
        }

        private void BtnKriek_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Kriek";
            updateDrank(naam);
        }

        private void BtnIcedTea_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Iced Tea";
            updateDrank(naam);
        }

        private void BtnIcedTeaGreen_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Iced Tea Green";
            updateDrank(naam);
        }

        private void BtnRodeo_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Rodeo";
            updateDrank(naam);
        }

        private void BtnRodeoExo_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Rodeo Exotic";
            updateDrank(naam);
        }

        private void BtnBWater_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Bruis Water";
            updateDrank(naam);
        }

        private void BtnDuvel_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Duvel";
            updateDrank(naam);
        }

        private void BtnLachouffe_Click(object sender, RoutedEventArgs e)
        {
            String naam = "La Chouffe";
            updateDrank(naam);
        }

        private void BtnDesp_Click(object sender, RoutedEventArgs e)
        {
            String naam = "Desperados";
            updateDrank(naam);
        }

        private void BtnKarm_Click(object sender, RoutedEventArgs e)
        {
            string naam = "Karmeliet";
            updateDrank(naam);
        }

        private void BtnBarBar_Click(object sender, RoutedEventArgs e)
        {
            string naam = "BarBar";
            updateDrank(naam);
        }
        private void BtnExtra1_Click(object sender, RoutedEventArgs e)
        {
            string naam = getExtraDrankName(1);
            updateDrank(naam);
        }
        private void BtnExtra2_Click(object sender, RoutedEventArgs e)
        {
            string naam = getExtraDrankName(1);
            updateDrank(naam);
        }
        private void BtnExtra3_Click(object sender, RoutedEventArgs e)
        {
            string naam = getExtraDrankName(1);
            updateDrank(naam);
        }
        private void BtnExtra4_Click(object sender, RoutedEventArgs e)
        {
            string naam = getExtraDrankName(1);
            updateDrank(naam);
        }
        private void BtnExtra5_Click(object sender, RoutedEventArgs e)
        {
            string naam = getExtraDrankName(1);
            updateDrank(naam);
        }
        private void BtnExtra6_Click(object sender, RoutedEventArgs e)
        {
            string naam = getExtraDrankName(1);
            updateDrank(naam);
        }
        private void BtnExtra7_Click(object sender, RoutedEventArgs e)
        {
            string naam = getExtraDrankName(1);
            updateDrank(naam);
        }
        private void BtnExtra8_Click(object sender, RoutedEventArgs e)
        {
            string naam = getExtraDrankName(1);
            updateDrank(naam);
        }
        //extra knoppen na deze

        private String getExtraDrankName(int v)
        {
            return _drankenlijst.GetDranken()[v+15].naam;
        }

        private void addDrankKnop(Drank drank,int i)
        {
            switch (i)
            {
                case 1:            
                    BtnExtra1.Visibility = Visibility.Visible;
                    BtnExtra1.Content = drank.naam;

                    break;
                case 2:
                    BtnExtra2.Visibility = Visibility.Visible;
                    BtnExtra2.Content = drank.naam;
                    break;
                case 3:
                    BtnExtra3.Visibility = Visibility.Visible;
                    BtnExtra3.Content = drank.naam;
                    break;
                case 4:
                    BtnExtra4.Visibility = Visibility.Visible;
                    BtnExtra4.Content = drank.naam;
                    break;
                case 5:
                    BtnExtra5.Visibility = Visibility.Visible;
                    BtnExtra5.Content = drank.naam;
                    break;
                case 6:
                    BtnExtra6.Visibility = Visibility.Visible;
                    BtnExtra6.Content = drank.naam;
                    break;
                case 7:
                    BtnExtra7.Visibility = Visibility.Visible;
                    BtnExtra7.Content = drank.naam;
                    break;
                case 8:
                    BtnExtra8.Visibility = Visibility.Visible;
                    BtnExtra8.Content = drank.naam;
                    break;

                default:
                    break;
            } 
        }
        private void TappersWindow_Closing(object sender, CancelEventArgs e)
        {
            string msg = "Wilt u de eindkassa maken?";
            MessageBoxResult result =
              MessageBox.Show(
                msg,
                "Data App",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                GeldRepository tempRepository = new GeldRepository();

                tempRepository = tempRepository.Merge(_kassa, _Kluis);
                MessageBox.Show("eindkassa wordt gemaakt");
                string values = File.ReadLines("xml/Kluisbladen/" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + "dagTemp.txt").Last();
                File.Delete("xml/Kluisbladen/" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + "dagTemp.txt");
                string[] value = values.Split(':');
                File.AppendAllText("xml/Kluisbladen/" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + "dag.txt", value[0] + ":" + value[1] + ":" + tempRepository.Totaal() + Environment.NewLine);
                tempRepository.Export("Geld");
                File.Delete("xml/Kluis.txt");
                File.Delete("xml/Kassa.txt");
            }
        }

        private void BtnvanKluis_Click(object sender, RoutedEventArgs e)
        {
            if (_kassaText.Any())
            {
                List<Eenheid> test = new List<Eenheid>();
                foreach (var item in _kassaText)
                {
                    test.Add(new Eenheid(item.Key.Trim('€'), item.Value));
                }
                _Kluis.afTrekken(test);
                _Kluis.Export("Kluis");
                _kassa.optellenKassa(_kassaText);
                _kassa.Export("Kassa");
                _kassa.Import("Kassa");
                
                LBoxKassaInhoud.Items.Clear();
                foreach (var eenheid in _kassa.toObject())
                {
                    this.LBoxKassaInhoud.Items.Add(eenheid);

                }
                _wissel.Clr();
                Lboxwissel.Items.Clear();
                LblWisselgeld.Content = _wissel.Totaal();
                _last.Clear();
                _kassaText.Clear();
                LblKassaTerug.Content = "";
                UpdateKassa();
                LBoxTerugGave.Items.Clear();
                LBoxKassaInhoud.Visibility = Visibility.Visible;
                LBoxTerugGave.Visibility = Visibility.Hidden;
                _bestellingText.Clear();
                UpdateBestelling();
                LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());
                MakeLblKassaTerug();
            }
            else
            {
                MessageBox.Show("ongeldige verwerking");
            }
        }

        private void BtnNaarKluis_Click(object sender, RoutedEventArgs e)
        {
            if (_kassaText.Any())
            {
                List<Eenheid> test = new List<Eenheid>();
                foreach (var item in _kassaText)
                {
                    test.Add(new Eenheid(item.Key.Trim('€'), item.Value));
                }
                _Kluis.optellenKassa(_kassaText);
                _Kluis.Export("Kluis");
                _kassa.afTrekken(test);
                _kassa.Export("Kassa");
                _kassa.Import("Kassa");

                LBoxKassaInhoud.Items.Clear();
                foreach (var eenheid in _kassa.toObject())
                {
                    this.LBoxKassaInhoud.Items.Add(eenheid);

                }
                _wissel.Clr();
                Lboxwissel.Items.Clear();
                LblWisselgeld.Content = _wissel.Totaal();
                _last.Clear();
                _kassaText.Clear();
                LblKassaTerug.Content = "";
                UpdateKassa();
                LBoxTerugGave.Items.Clear();
                LBoxKassaInhoud.Visibility = Visibility.Visible;
                LBoxTerugGave.Visibility = Visibility.Hidden;
                _bestellingText.Clear();
                UpdateBestelling();
                LblBestelPrijs.Content = String.Format("{0:C2}", MakeBestelPrijs());
                MakeLblKassaTerug();
            }
            else
            {
                MessageBox.Show("ongeldige verwerking");
            }
        }
    }
}
