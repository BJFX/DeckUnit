﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoonieBear.DeckUnit.Mov4500UI.ViewModel
{
    public class ViewModelLocator
    {
        public MainFrameViewModel _mainFrameViewModel;
        public HomePageViewModel _homwPageViewModel;
        /// <summary>
        /// Gets the MainFrame ViewModel
        /// </summary>
        public MainFrameViewModel MainFrameViewModel
        {
            get
            {
                // Creates the MainFrame ViewModel
                if (_mainFrameViewModel == null)
                {
                    _mainFrameViewModel = new MainFrameViewModel();
                    _mainFrameViewModel.Initialize();
                }
                return _mainFrameViewModel;
            }
        }
        public HomePageViewModel HomePageViewModel
        {
            get
            {
                // Creates the MainFrame ViewModel
                if (_homwPageViewModel == null)
                {
                    _homwPageViewModel = new HomePageViewModel();
                    _homwPageViewModel.Initialize();
                }
                return _homwPageViewModel;
            }
        }
    }
}