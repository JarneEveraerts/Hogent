using Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AutoWindow : Window
    {
        private DomeinController _dc;
        private InfoWindow _infoWindow;

        /*
        public InfoWindow InfoWindow 
        { 
            get 
            { 
                return _infoWindow; 
            } 
            set 
            { 
                if(_infoWindow != value)
                {
                    _infoWindow = value;
                }
            } 
        }
        */

        public AutoWindow(DomeinController dc)
        {
            InitializeComponent();

            _dc = dc;

            _autosInfo = _dc.GeefAutos();
           foreach (List<String> autoInfo in _autosInfo)
            {
                _autosView.Add(new AutoView(autoInfo[0], autoInfo[1], autoInfo[2]));
            }
            dgSimple.ItemsSource = _autosView;


            //List<string> geordendeMerken = _dc.GeefMogelijkeMerken().OrderBy(s => s).ToList();
           
            List<string> geordendeMerken = new(_dc.GeefMogelijkeMerken());
            
            geordendeMerken.Sort();
            
            cmbMerk.ItemsSource = geordendeMerken;
        }

        List<List<String>> _autosInfo;
        // beter dan list: WPF wordt ingelicht van veranderingen
        private ObservableCollection<AutoView> _autosView = new();

        private void lbOverzichtAutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
            if (lbOverzichtAutos.SelectedItem is not null)
            {
                var autoView = lbOverzichtAutos.SelectedItem as AutoView;

                if (autoView != null)
                {
                    txtNummerplaat.Text = autoView.Nummerplaat;
                    cmbMerk.SelectedItem = autoView.Merk;
                    cmbModel.SelectedItem = autoView.Model;
                }
            }
            */
        }

        private void cmbMerk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbMerk.SelectedItem is not null)
            {
                cmbModel.ItemsSource = _dc.GeefMogelijkeModellen(cmbMerk.SelectedItem as String);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            //lbOverzichtAutos.UnselectAll();
            txtNummerplaat.Text = String.Empty;

            cmbMerk.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
            _autosView.Clear();
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {

            if (_infoWindow == null)
                _infoWindow = new InfoWindow();
            _infoWindow.Show(); // alternatief: ShowDialog() - modal

            /*
            _autosView.Add(new AutoView( "NEW-1234-1", "Mercedes", "E-Coupe" ));
            */

            if (cmbMerk.SelectedItem is null)
            {
                MessageBox.Show("Er werd geen merk geselecteerd", "Opmerking", 
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (cmbModel.SelectedItem is null)
            {
                MessageBox.Show("Er werd geen model geselecteerd", "Opmerking",
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                _dc.RegistreerAuto(txtNummerplaat.Text, cmbMerk.Text, cmbModel.SelectedItem as String);
            }
            catch (GarageException ex)
            {
                MessageBox.Show(ex.Message, "Opslaan auto fout",
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (RegistreerException)
            {
                MessageBoxResult result = MessageBox.Show("Deze nummerplaat is reeds geregistreerd. Wenst u de registratie aan te passen?", 
                                "Opmerking",
                                 MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        _dc.WijzigAuto(txtNummerplaat.Text, cmbMerk.Text, cmbModel.SelectedItem as String);
                    }
                    catch (GarageException ex)
                    {
                        MessageBox.Show(ex.Message, "Opslaan auto fout",
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }

        private void btnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            //_autosView[0].Merk = "Tesla";
            //_autosView[0].Nummerplaat = "Onbekend";
            //_autosView[0].Model = "3";
            try
            {
                _dc.VerwijderAuto(txtNummerplaat.Text);                
            }
            catch (GarageException ex)
            {
                MessageBox.Show(ex.Message, "Verwijder auto opmerking",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
