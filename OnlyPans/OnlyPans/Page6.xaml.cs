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

namespace OnlyPans
{
    /// <summary>
    /// Lógica de interacción para Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            cbxSexo.Items.Clear();
            for (int i = 0; i < w.NProductos; i++) {
                cbxSexo.Items.Add(w.Producto[i, 0]);
            }
            cbxSexo.SelectedIndex = 0;

            //actualizar valor
            sldEdad.Value = 1;
            sldEdad.Minimum = 1;
            UpdatePrice();

        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            //if sldEdad.Value
            MainWindow w = (MainWindow)Window.GetWindow(this);
            /*
            0 -> id producto
            1 -> Cantidad
            2 -> Total
            3 -> id empleado que lo vendió
            4 -> Nombre comprador
            5 -> Cedula comprador
            6 -> Fecha
            */
            w.Venta[w.NVentas, 0] = cbxSexo.SelectedIndex;
            w.Venta[w.NVentas, 1] = sldEdad.Value;
            w.Venta[w.NVentas, 2] = (Int32.Parse(w.Producto[cbxSexo.SelectedIndex, 1].ToString()) * sldEdad.Value);
            w.Venta[w.NVentas, 3] = w.ID; //ARREGLAR
            w.Venta[w.NVentas, 4] = txtNombre.Text;
            w.Venta[w.NVentas, 5] = txtCedula.Text;
            w.Venta[w.NVentas, 6] = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            //MessageBox.Show(w.Venta[w.NVentas, 2].ToString());
            w.NVentas = w.NVentas + 1;

            w.MainFrame.Content = w.P2;
        }

        private void sldEdad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            if (cbxSexo.SelectedIndex >= 0){ 
                MainWindow w = (MainWindow)Window.GetWindow(this);
                lblEdad.Content = sldEdad.Value;
                lblValor.Content = (Int32.Parse(w.Producto[cbxSexo.SelectedIndex, 1].ToString()) * sldEdad.Value).ToString() + "$";
            }
        }

        private void cbxSexo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdatePrice();
        }
    }
}
