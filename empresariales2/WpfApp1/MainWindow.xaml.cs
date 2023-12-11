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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Password;

            if (usuario == "samuel" && contraseña == "123456")
            {
                Window1 window = new Window1();
                window.Show();
            }
            else
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Usuario o contraseña incorrectos", "Error al iniciar sesión");

                result = MessageBoxResult.OK;
            }


            
        }
    }
}
