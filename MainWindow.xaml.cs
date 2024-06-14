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

namespace UsoDatePicker_Practico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Cuando queremos llevar a cabo las lecturas de las fechas  seleccionadas hacemos uso de la 
            //propiedad Selected.Date del control, en este caso el control tiene como nombre "dpFecha"

            //recibimos un objeto de tipo DateTime, hemos colocado un signo de interrogacion, con esto estamos 
            //haciendo  que el DateTime sea Nulleable, lo cual quiere decir que puede recibir el objeto de tipo
            //DateTime o puede recibir  un null, cuando el usuario no hizo ninguna seleccion de fecha 


            DateTime? fecha = dpFecha.SelectedDate;

            MessageBox.Show(fecha.ToString(), "La fecha Seleccionada");
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
