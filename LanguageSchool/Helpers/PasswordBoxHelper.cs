using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace LanguageSchool.Helpers
{
    using System.Windows;
    using System.Windows.Controls;

    public static class PasswordBoxHelper
    {
        public static readonly DependencyProperty BindablePassword =
            DependencyProperty.RegisterAttached(
                "BindablePassword",
                typeof(string),
                typeof(PasswordBoxHelper),
                new FrameworkPropertyMetadata(string.Empty, OnBindablePasswordChanged));

        public static string GetBindablePassword(DependencyObject obj) =>
            (string)obj.GetValue(BindablePassword);

        public static void SetBindablePassword(DependencyObject obj, string value) =>
            obj.SetValue(BindablePassword, value);

        private static void OnBindablePasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PasswordBox passwordBox)
            {
                passwordBox.Password = e.NewValue as string ?? string.Empty;
                passwordBox.PasswordChanged += (sender, args) =>
                    passwordBox.SetValue(BindablePassword, passwordBox.Password);
            }
        }
    }
}
