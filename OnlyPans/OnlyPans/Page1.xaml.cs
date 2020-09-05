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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            bool si = false;
            for (int i = 0; i < w.NEmpleados; i++)
            {
                if ((txtUser.Text == w.Empleado[i, 4].ToString() || txtUser.Text == w.Empleado[i, 0].ToString()) && (txtPass.Password == w.Empleado[i, 5].ToString()))
                {
                    //MessageBox.Show((w.Empleado[i, 6]).ToString());

                    w.lblAdmin.Content = w.Empleado[i, 0].ToString() + " - Empleado";
                    if (Convert.ToBoolean(w.Empleado[i, 6]) == true)
                    {
                        w.ADMIN = true;
                        w.lblAdmin.Content = w.Empleado[i, 0].ToString() + " - Administrador";
                        w.lblEmpleados.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        w.lblEmpleados.Visibility = Visibility.Hidden;
                    }
                    w.MainFrame.Content = w.P2;

                    txtUser.Text = "";

                    w.lblAdmin.Visibility = Visibility.Visible;
                    w.lblResumen.Visibility = Visibility.Visible;
                    w.lblInventario.Visibility = Visibility.Visible;
                    w.lblCerrar.Visibility = Visibility.Visible;

                    si = true;
                }
            }
            if (si = false)
            {
                MessageBox.Show("Credenciales Incorrectas");
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
