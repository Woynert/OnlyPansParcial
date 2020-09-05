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
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();


        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int _a = lbxVentas.SelectedIndex;
            lbxVentas.Items.Clear();
            ShowContent();
            lbxVentas.SelectedIndex = 0;

            MainWindow w = (MainWindow)Window.GetWindow(this);
            if (w.ADMIN)
            {
                btnNuevaVenta.Visibility = Visibility.Visible;
            }
            else
            {
                btnNuevaVenta.Visibility = Visibility.Visible;
            }
            ShowTotal();
        }

        private void ShowContent()
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            //Actualizar lista
            for (int i = 0; i < w.NVentas; i++)
            {
                lbxVentas.Items.Add((w.Producto[Int32.Parse(w.Venta[i, 0].ToString()), 0] + " - x" + w.Venta[i, 1].ToString()));
                
            }
            lbxVentas.SelectedIndex = 0;
            ShowTotal();
        }
        private void lbxVentas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);

            if (lbxVentas.SelectedIndex >= 0){
                int _id = lbxVentas.SelectedIndex;
                //MessageBox.Show(_id.ToString());
                //MessageBox.Show(w.Venta[_id, 0].ToString());
                lblProducto.Content = w.Producto[Int32.Parse(w.Venta[_id, 0].ToString()), 0];
                lblPrecio.Content = w.Producto[Int32.Parse(w.Venta[_id, 0].ToString()), 1];
                lblCantidad.Content = w.Venta[_id, 1].ToString();
                lblTotal.Content = w.Venta[_id, 2].ToString();
                lblFecha.Content = w.Venta[_id, 6];
                lblNombreEmpleado.Content = w.Empleado[Int32.Parse(w.Venta[_id, 3].ToString()), 0];
                lblNombreCliente.Content = w.Venta[_id, 4];
                lblCedulaCliente.Content = w.Venta[_id, 5];
            }
        }

        private void lblProducto_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Enviar a la pagina de información del producto
        }

        private void btnNuevaVenta_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.MainFrame.Content = w.P6;
        }

        private void ShowTotal()
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            int sum = 0;
            for (int i = 0; i < w.NVentas; i++)
            {
                sum += Int32.Parse(w.Venta[i, 2].ToString());
            }
            //MessageBox.Show(sum.ToString());
            lblGanancias.Content = sum.ToString() + "$";
        }
    }
}
