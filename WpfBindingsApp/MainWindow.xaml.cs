using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBindingsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user = new()
        {
            Name = "Sammy",
            Age = 31,
            Email = "sammy@yahoo.com"
        };

        ListData listData = new();
        public MainWindow()
        {
            InitializeComponent();

            //this.DataContext = user;

            //Binding binding = new();
            //binding.ElementName = "txtBox";
            //binding.Path = new PropertyPath("Text");

            //txtBlock.SetBinding(TextBlock.TextProperty, binding);

            lstBox.DataContext = listData;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //user.Name = "Billy";
            //user.Langs.Add("Php");

            //MessageBox.Show(user.ToString());

            listData.Empls.Add("sam");
            string msg = "";
            foreach (var i in listData.Empls)
                msg += i;
            MessageBox.Show(msg);
        }
    }

    public class ListData
    {
        public ObservableCollection<string> Empls { set; get; } = new() { "bob", "joe" };
    }

}