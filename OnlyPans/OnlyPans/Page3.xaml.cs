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
    /// Lógica de interacción para Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        bool Iniciado = false;
        public Page3()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!Iniciado) { 
                ShowContent(); //MessageBox.Show("Loaded");
                Iniciado = true;
            }
        }

        private void lbxProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            MainWindow w = (MainWindow)Window.GetWindow(this);
            //Mostrar contenido
            lblProducto.Content = w.Producto[Int16.Parse((lbxProductos.SelectedIndex.ToString())), 0];
            lblPrecio.Content = w.Producto[Int16.Parse((lbxProductos.SelectedIndex.ToString())), 1] + "$";

        }

        private void ShowContent()
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            //Actualizar lista
            for (int i = 0; i <= w.NProductos; i++)
            {
                lbxProductos.Items.Add(w.Producto[i, 0]);
                lbxProductosId.Items.Add(i);
            }
        }
    }
}
