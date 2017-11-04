using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ApplicationNavigation.Helpers;

namespace ApplicationNavigation.View
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            if(GameController.Enemy.currentHealthPoints <= 0)
            {
                
                Lbl_Result.Content = " You Won";
            }
            if (GameController.Player.currentHealthPoints <= 0)
            {
                Lbl_Result.Content = " You Lost";
            }


        }


    }
}
