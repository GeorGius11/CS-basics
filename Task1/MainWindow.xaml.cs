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

namespace HomeWork7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n;
        Stack<int> stack;
        public MainWindow()
        {
            InitializeComponent();
            stack = new Stack<int>();
        }
        
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            stack.Push(Convert.ToInt32(Number.Content));
            NumOfActs.Content = 0;
            Number.Content = 1;
            
        }

        private void AddOneButton_Click(object sender, RoutedEventArgs e)
        {
            stack.Push(Convert.ToInt32(Number.Content));
            
            NumOfActs.Content = Convert.ToInt32(NumOfActs.Content) + 1;
            Number.Content = Convert.ToInt32(Number.Content) + 1;
            
            CheckNum(Convert.ToInt32(Number.Content));
            
        }

        private void MultBy2Button_Click(object sender, RoutedEventArgs e)
        {
            stack.Push(Convert.ToInt32(Number.Content));
            
            NumOfActs.Content = Convert.ToInt32(NumOfActs.Content) + 1;
            Number.Content = Convert.ToInt32(Number.Content) * 2;
            
            CheckNum(Convert.ToInt32(Number.Content));
            
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Number.Content = 1;
            Random r = new Random();
            n = r.Next(2, 1000);
            MessageBox.Show($"You must get {n}");
            
            
            MultBy2Button.IsEnabled = true;
            AddOneButton.IsEnabled = true;
            Reset.IsEnabled = true;
            ReturnButton.IsEnabled = true;
            LabelGuessNum.Visibility = Visibility.Visible;
            SearchedNum.Visibility = Visibility.Visible;
            SearchedNum.Content = n;

        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Number.Content = stack.Pop();
            }
            catch
            {
            };
        }

        public void CheckNum(int num)
        {
            if (num == n)
            {
                MessageBox.Show("Congrrats! You won)");
                
                MultBy2Button.IsEnabled = false;
                AddOneButton.IsEnabled = false;
                Reset.IsEnabled = false;
                ReturnButton.IsEnabled = false;
                LabelGuessNum.Visibility = Visibility.Hidden;
                SearchedNum.Visibility = Visibility.Hidden;
                NumOfActs.Content = 1;
            }

        }
    }
}
