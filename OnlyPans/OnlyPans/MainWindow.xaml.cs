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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {
        //Productos
        public Object[,] Producto = new Object[100, 2];
        /*
        0 -> nombre
        1 -> precio
        */

        //Empleados
        public Object[,] Empleado = new Object[100, 7];
        /*
        0 -> nombre
        1 -> cedula
        2 -> Edad
        3 -> Sexo
        4 -> Email
        5 -> Contraseña
        6 -> Admin
        */

        //Ventas
        public Object[,] Venta = new Object[100, 7];
        /*
        0 -> id producto
        1 -> Cantidad
        2 -> Total
        3 -> id empleado que lo vendió
        4 -> Nombre comprador
        5 -> Cedula comprador
        6 -> Fecha
        */

        public int NProductos = 0;
        public int NEmpleados = 0;
        public int NVentas = 0;

        //Paginas
        public Page1 P1 = new Page1();
        public Page2 P2 = new Page2();
        public Page3 P3 = new Page3();
        public Page4 P4 = new Page4();
        public Page5 P5 = new Page5();
        public Page6 P6 = new Page6();

        public bool ADMIN = false;
        public int ID = 0;

        public MainWindow()
        {
            InitializeComponent();
            //Application.Current.MainWindow.Height = 100;

            lblAdmin.Visibility = Visibility.Hidden;
            lblResumen.Visibility = Visibility.Hidden;
            lblInventario.Visibility = Visibility.Hidden;
            lblEmpleados.Visibility = Visibility.Hidden;
            lblCerrar.Visibility = Visibility.Hidden;

            MainFrame.Content = P1;

            //variables de prueba
            //productos
            NProductos = 3;
            Producto[0, 0] = "Pan Alineado";
            Producto[0, 1] = 1000;
            Producto[1, 0] = "Pan No Alineado";
            Producto[1, 1] = 500;
            Producto[2, 0] = "Especial";
            Producto[2, 1] = 2000;

            //empleados
            NEmpleados = 2;
            Empleado[0, 0] = "Lorem";
            Empleado[0, 1] = "017405727";
            Empleado[0, 2] = 10;
            Empleado[0, 3] = "Hombre";
            Empleado[0, 4] = "1@hey.com";
            Empleado[0, 5] = "123";
            Empleado[0, 6] = true;

            Empleado[1, 0] = "Ipsum";
            Empleado[1, 1] = "2572570";
            Empleado[1, 2] = 20;
            Empleado[1, 3] = "Mujer";
            Empleado[1, 4] = "2@hey.com";
            Empleado[1, 5] = "1234";
            Empleado[1, 6] = false;

            //Ventas
            NVentas = 1;
            Venta[0, 0] = 1;
            Venta[0, 1] = 4;
            Venta[0, 2] = 2000;
            Venta[0, 3] = 1;
            Venta[0, 4] = "Mario";
            Venta[0, 5] = "102143254";
            Venta[0, 6] = "02/03/2020 23:02 p.m.";

        }

        //resumen
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = P2;
        }

        //empleados
        private void Label_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = P4;
        }

        //Inventario
        private void Label_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = P3;
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        //cerrar sesión
        private void lblAdmin_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ADMIN = false;
            lblAdmin.Visibility = Visibility.Hidden;
            lblResumen.Visibility = Visibility.Hidden;
            lblInventario.Visibility = Visibility.Hidden;
            lblEmpleados.Visibility = Visibility.Hidden;
            lblCerrar.Visibility = Visibility.Hidden;
            MainFrame.Content = P1;
        }
    }
}
