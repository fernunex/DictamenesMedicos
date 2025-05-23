﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace DictamenesMedicos.CustomControls
{
    /// <summary>
    /// Interaction logic for BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public BindablePasswordBox()
        {
            InitializeComponent();
            txtPassword.PasswordChanged += OnPasswordChanged;
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password",
                typeof(SecureString),
                typeof(BindablePasswordBox),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public SecureString Password
        {
            get { return (SecureString)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            SetCurrentValue(PasswordProperty, txtPassword.SecurePassword);
        }
    }
}
