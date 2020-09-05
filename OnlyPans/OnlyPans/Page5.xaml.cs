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
    /// Lógica de interacción para Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }


        private void sldEdad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblEdad.Content = sldEdad.Value.ToString();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            /*
           0 -> nombre
           1 -> cedula
           2 -> Edad
           3 -> Sexo
           4 -> Email
           5 -> Contraseña
           */
            w.Empleado[w.NEmpleados, 0] = txtNombre.Text;
            w.Empleado[w.NEmpleados, 1] = txtCedula.Text;
            w.Empleado[w.NEmpleados, 2] = sldEdad.Value;
            w.Empleado[w.NEmpleados, 3] = cbxSexo.SelectedItem;
            w.Empleado[w.NEmpleados, 4] = txtEmail.Text;
            w.Empleado[w.NEmpleados, 5] = txtPass.Password;
            w.Empleado[w.NEmpleados, 6] = cbxAdmin.Content;

            txtNombre.Text = "";
            txtCedula.Text = "";
            sldEdad.Value = 0;
            cbxSexo.SelectedIndex = 0;
            txtEmail.Text = "";
            txtPass.Password = "";
            cbxAdmin.Content = false;

            w.NEmpleados = w.NEmpleados+1;
            w.MainFrame.Content = w.P4;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
