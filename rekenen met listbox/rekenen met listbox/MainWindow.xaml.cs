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

namespace rekenen_met_listbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            addTextBox.Focus();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem newitem = new ListBoxItem();
            newitem.Content = addTextBox.Text;
            numberListBox.Items.Add(newitem);
            addTextBox.Clear();
            addTextBox.Focus();
        }

        private void sumButton_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int number;
            //ListBoxItem item;

            foreach (ListBoxItem item in numberListBox.Items)
            {
                sum += Convert.ToInt32(item.Content);
            }
            sumTextBox.Text = Convert.ToString(sum);

            //for (int index = 0; index < numberListBox.Items.Count; index++)
            //{
            //    item = (ListBoxItem)numberListBox.Items[index];
            //    number = Convert.ToInt32(item.Content);
            //    sum += number;
            //}
            //sumTextBox.Text = Convert.ToString(sum);
        }

        private void largestButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = (ListBoxItem)numberListBox.Items[0];
            int largest = Convert.ToInt32(item.Content);
            int number;

            for (int index = 1; index < numberListBox.Items.Count; index++)
            {
                item = (ListBoxItem)numberListBox.Items[index];
                number = Convert.ToInt32(item.Content);
                if (number > largest)
                {
                    largest = number;
                }
            }
            largestTextBox.Text = Convert.ToString(largest);
        }
    }
}
