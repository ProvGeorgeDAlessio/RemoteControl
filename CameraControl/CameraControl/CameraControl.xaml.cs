using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViscaLibrary;


namespace CameraControl
{
    /// <summary>
    /// Interaction logic for ToolboxControl.xaml
    /// </summary>
    [ProvideToolboxControl("General", true)]
    public partial class CameraControl : UserControl
    {
       
        private CameraControlModel _controlModel;
        public CameraControl()
        {
            this.DataContext = new CameraControlModel();
            _controlModel = (CameraControlModel)DataContext;
            InitializeComponent();            
        }
        public string Title
        {
            get { return _controlModel.Title; }
            set { _controlModel.Title = value; }
        }
        private void up_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.up_Click()", this.ToString()));
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.down_Click()", this.ToString()));
        }
        private void left_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.left_Click()", this.ToString()));
        }
        private void right_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.right_Click()", this.ToString()));
        }
        private void home_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.home_Click()", this.ToString()));
        }

        private void zoomin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.zoomin_Click()", this.ToString()));
        }
        private void zoomout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.zoomout_Click()", this.ToString()));
        }
        private void on_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.on_Click()", this.ToString()));
        }
        private void off_Click(object sender, RoutedEventArgs e)
        {
            ViscaService service = new ViscaService();
            service.SerialCmdSend("off");
        }
    }
}
