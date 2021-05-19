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
using System.Windows.Shapes;

namespace task2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int num;
        public Window1()
        {
            InitializeComponent();
            Random r = new Random();
            num = r.Next(1, 101);
        }

        private void SaveButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)        
            {
                try
                {
                    if (Convert.ToInt32(UserInput.Text) == num)
                    {
                        MessageBox.Show($"Congrats! You won) Attempts: {Convert.ToString(NumOfAttempts.Content)}");
                        this.Close();
                    }
                    else if (Convert.ToInt32(UserInput.Text) < num)
                    {
                        MessageForUser.Content = "The number is bigger. Try again";
                        NumOfAttempts.Content = Convert.ToInt32(NumOfAttempts.Content) + 1;
                        UserInput.Clear();
                    }
                    else
                    {
                        MessageForUser.Content = "The number is smaller. Try again";
                        NumOfAttempts.Content = Convert.ToInt32(NumOfAttempts.Content) + 1;
                        UserInput.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Wrong input format");
                    UserInput.Clear();
                }
            }
        }

        private void UserInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
