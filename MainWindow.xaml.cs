using Gyakorlas_Cars_Owners.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gyakorlas_GUI_car_dealers
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        DataContext context = new DataContext();

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string tulajdonsagNev)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tulajdonsagNev));
        }
        public ObservableCollection<Car> Cars { get; set; }
        public ObservableCollection<Owner> Owners { get; set; }

        private Owner selOwner;
        public Owner SelOwner
        {
            get { return selOwner; }
            set { selOwner = value; OnPropertyChanged(nameof(SelOwner)); }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            context.Cars.Load();
            context.Owners.Load();
            Cars = new ObservableCollection<Car>(context.Cars.Local);
            Owners = new ObservableCollection<Owner>(context.Owners.Local);
        }

        private void name_Cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Owner selectedOwner = (Owner)name_Cbx.SelectedItem;
            if(selectedOwner != null)
            {
                var ownersCars = new ObservableCollection<Car>(context.Cars.Local.Where(x => x.ownerid == selectedOwner.id));
                data_Dg.ItemsSource = ownersCars;
            }
        }
    }
}