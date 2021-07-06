using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            button1.Content = String.Empty;
        }



        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    PopIt.IsOpen = !PopIt.IsOpen;
        //}
        //
        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}



        //ListBoxItem selectedCard;
        //
        //private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    selectedCard = (cardBox.SelectedItem as ListBoxItem);
        //}
        //
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    myPopUp.IsOpen = true;
        //}
        //
        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    if (selectedCard != null)
        //    {
        //
        //        // value of valueLabel
        //        ((selectedCard.Content as StackPanel).Children[1] as Label).Content = valueTextBox.Text;
        //        myPopUp.IsOpen = false;
        //    }
        //}



        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show(e.GetPosition(this).X.ToString());
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show(e.GetPosition(this).X.ToString() + " " + e.GetPosition(this).Y.ToString());
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                button1.Content += " ";

            else
                button1.Content += e.Key.ToString();
        }

        private void Window_LostFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lost Focus");
        }

        private void Window_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            MessageBox.Show("Lost Focus");
            myTextBox.Focus();
        }

        private void myTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            myTextBox.Focus();

        }
    }
}
