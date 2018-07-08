using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarCatalog
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

        private void ListofContent_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                String key = ListofContent.SelectedValue.ToString();
                String path = @"..\..\Data\" + key + ".xaml";

                Reader.Document = (FlowDocument)XamlReader.Load(File.OpenRead(path));
            }
            catch (Exception err)
            {
                MessageBox.Show("Данная страница каталога находится в разработке", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
