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
        
        public Page3()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowContent(); //MessageBox.Show("Loaded");
        }

        private void lbxProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Mostrar contenido
        }

        private void ShowContent()
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            //Actualizar lista
            for (int i = 0; i <= w.NProductos; i++)
            {
                lbxProductos.Items.Add(w.Producto[i, 0]);
            }
        }
    }
}
