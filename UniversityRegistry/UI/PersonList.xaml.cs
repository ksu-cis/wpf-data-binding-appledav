﻿using System;
using System.Collections.Generic;
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

namespace UniversityRegistry.UI
{
    /// <summary>
    /// Interaction logic for RegistryList.xaml
    /// </summary>
    public partial class PersonList : UserControl
    {
        public PersonList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// An event handler for the selection
        /// </summary>
        public event SelectionChangedEventHandler SelectionChanged;


        /// <summary>
        /// The event listener for the event handler above
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }
    }
}
