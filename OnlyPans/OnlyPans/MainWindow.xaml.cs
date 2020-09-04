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
        Object[,] Producto = new Object[10, 2];
        /*
        0 -> nombre
        1 -> precio
        */

        //Empleados
        Object[,] Empleado = new Object[10, 6];
        /*
        0 -> nombre
        1 -> cedula
        2 -> Edad
        3 -> Sexo
        4 -> Email
        5 -> Contraseña
        */

        //Ventas
        int[,] Venta = new int[10, 4];
        /*
        0 -> id producto
        1 -> Cantidad
        2 -> Total
        3 -> id empleado que lo vendió
        */

        public MainWindow()
        {
            InitializeComponent();
            //Application.Current.MainWindow.Height = 100;
            MainFrame.Content = new Page2();

            //variables de prueba
            //productos
            Producto[0, 0] = "Pan Alineado";
            Producto[0, 1] = 1000;
            Producto[1, 0] = "Pan No Alineado";
            Producto[1, 1] = 500;
            Producto[2, 0] = "Especial";
            Producto[2, 1] = 2000;

            //empleados
            Empleado[0, 0] = "Lorem";
            Empleado[0, 1] = 017405727;
            Empleado[0, 2] = 10;
            Empleado[0, 3] = "Hombre";
            Empleado[0, 4] = "www@hey.com";
            Empleado[0, 5] = "buenasCaballeros";

            Empleado[1, 0] = "Ipsum";
            Empleado[1, 1] = 2572570;
            Empleado[1, 2] = 20;
            Empleado[1, 3] = "Mujer";
            Empleado[1, 4] = "www@Oh.com";
            Empleado[1, 5] = "buenasDamas";

            //Ventas
            Venta[0, 0] = 1;
            Venta[0, 1] = 2;
            Venta[0, 2] = 2000;
            Venta[0, 3] = 1;



        }
    }
}
