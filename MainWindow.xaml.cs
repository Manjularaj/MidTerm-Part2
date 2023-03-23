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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MidTerm_Part2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Apt> apartments = new List<Apt>();
        public MainWindow()
        {
            InitializeComponent();
            Preload();
            DisplayInformation();
            DisplayInformation();
        }

        void Preload()
        {
            Random rand = new Random();
            int end = 106;


            for (int i = 100; i < 301; i++)
            {
                string apart = "H" + i;


                if (rand.Next(2) != 0)
                {
                    int monthly = rand.Next(1000, 3000);

                    int bedrooms = rand.Next(1, 4);

                    apartments.Add(new Apt(apart, "Will", "Cram", monthly, bedrooms));

                }
                else
                {
                    apartments.Add(new Apt(apart, false));

                }


            }


        }

        public void DisplayInformation()
        {
            //Clear the Listbox
            lbTenance.Items.Clear();

            for (int i = 0; i < apartments.Count; i++)
            {

                lbTenance.Items.Add(apartments[i]);
            }

        }

        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {
            String userInput = txtFirstName.Text;
            String luserInput = txtLastName.Text;
            lbTenance.Items.Add(userInput);
            //lbTenance.Items.Add(luserInput);
        }

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }

}
