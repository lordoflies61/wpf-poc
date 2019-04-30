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
        public string MyProperty = "el valor";
        public MainWindow()
        {
            InitializeComponent();
            lista.Items.Add(new Person() { Name = "Ali", ID = "123A", Age = 20 });
            lista.Items.Add(new Person() { Name = "Akram", ID = "456X", Age = 35 });
            lista.Items.Add(new Person() { Name = "Salman", ID = "333E", Age = 49 });
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            // do something
            ellabel.Content = "Otro valorS";
            dynamic selectedItem = lista.SelectedItem;
            Window1 w = new Window1();
            w.property = selectedItem.Name;
            w.Show();
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Get label.
            var label = sender as Label;
            // ... Set date in content.
            label.Content = MyProperty;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
