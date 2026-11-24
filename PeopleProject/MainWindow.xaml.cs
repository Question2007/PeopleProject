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

namespace PeopleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        People p = new People();
        public MainWindow()
        {
            InitializeComponent();


        }

        private void btnEletkor_Click(object sender, RoutedEventArgs e)
        {
            if (eletkorTextBox.Text.IsWhiteSpace())
            {
                MessageBox.Show("Kérem adjon meg egy életkort!");
                return;
            }
            if (minTextBox.Text.IsWhiteSpace())
            {
                MessageBox.Show("Kérem adjon meg egy minimum életkort!");
                return;
            }
            if (maxTextBox.Text.IsWhiteSpace())
            {
                MessageBox.Show("Kérem adjon meg egy maximum életkort!");
                return;
            }
            else
            {
                p.UjSzemely(int.Parse(eletkorTextBox.Text));
                listBoxEletkorok.Items.Add(eletkorTextBox.Text);
                if (listBoxEletkorok.Items.Count > 1)
                {
                    MessageBox.Show($"Az átlag életkor: {p.AtlagEletkor(int.Parse(minTextBox.Text), int.Parse(maxTextBox.Text))}");
                }
                
            }
        }
    }
}