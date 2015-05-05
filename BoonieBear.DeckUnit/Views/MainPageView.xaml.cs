﻿using System.Windows;
using System.Windows.Controls;
using BoonieBear.DeckUnit.Views;

namespace BoonieBear.DeckUnit.Views
{

    public partial class MainPageView : Page
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        private void MainformPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            MainFrameViewModel.pMainFrame.IsShowBottomBar = Visibility.Hidden;
            MainFrameViewModel.pMainFrame.OptionPanelWidth = 0;
        }


    }
}
