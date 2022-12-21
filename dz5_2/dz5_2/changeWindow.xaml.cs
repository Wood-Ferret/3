using System;
using System.Windows;


namespace dz5_2
{
    /// <summary>
    /// Логика взаимодействия для changeWindow.xaml
    /// </summary>
    public partial class changeWindow : Window
    {
        public changeWindow()
        {
            InitializeComponent();
        }
        public int number;
        public string country;
        public string region;
        public string city;
        public string street;
        public int house;
        public int index;
        public bool[] error = new bool[3];
        public int maxnum = MainWindow.nomer;
       


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                error[i] = false;
            }
                
                if (int.TryParse(numberBox.Text, out number))
                {
                    if (number > 0)
                    {
                        if (number <= maxnum)
                        {
                            numbererrorLabel.Visibility = Visibility.Hidden;
                        error[0] = false;
                        }
                        else
                        {
                            numbererrorLabel.Visibility = Visibility.Visible;
                        error[0] = true;
                        }
                    }
                    else
                    {
                        numbererrorLabel.Visibility = Visibility.Visible;
                    error[0] = true;
                    }
                }
                else
                {
                    numbererrorLabel.Visibility = Visibility.Visible;
                error[0] = true;
                }
                country = countryBox.Text;
                region = regionBox.Text;
                city = cityBox.Text;
                street = streetBox.Text;
                if (int.TryParse(houseBox.Text, out house))
                {
                    if (house > 0)
                    {
                        errorhouseLabel.Visibility = Visibility.Hidden;
                    error[1] = false;
                    }
                }
                else
                {
                    errorhouseLabel.Visibility = Visibility.Visible;
                error[1] = true;
                }
                if (indexBox.Text.Length == 6 && int.TryParse(indexBox.Text, out index))
                {
                    if (index > 0)
                    {
                        errorindexLabel.Visibility = Visibility.Hidden;
                    error[2] = false;
                    }
                }
                else
                {
                    errorindexLabel.Visibility = Visibility.Visible;
                error[2] = true;
                }



            if (error[0] == false && error[1] == false && error[2] == false)
            {
                this.DialogResult = true;
            }
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            this.DialogResult=false;
        }
        
    }
}