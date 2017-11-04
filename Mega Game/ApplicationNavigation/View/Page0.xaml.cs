using System;
using System.Collections.Generic;
using System.Linq;
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
using ApplicationNavigation.View;
using ApplicationNavigation.Model;
using ApplicationNavigation.Helpers;



namespace ApplicationNavigation.View
{
    
    public partial class Page0 : Page
    {
        public Page0()
        {
            InitializeComponent();
        }

        private void Btn_Warrior_Click(object sender, RoutedEventArgs e)
        {
            GameController.ChooseClass("Warrior");
            this.NavigationService.Navigate(new Page1());
            
        }

        private void Btn_Mage_Click(object sender, RoutedEventArgs e)
        {
            GameController.ChooseClass("Mage");
            this.NavigationService.Navigate(new Page1());
        }

        private void Btn_Thief_Click(object sender, RoutedEventArgs e)
        {
            GameController.ChooseClass("Thief");
            this.NavigationService.Navigate(new Page1());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
