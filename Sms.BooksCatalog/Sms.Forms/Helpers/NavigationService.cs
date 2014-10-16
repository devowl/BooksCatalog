using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Sms.Forms.Helpers
{
    /// <summary>
    /// Класс дающий создание навигации
    /// </summary>
    /// <remarks>
    /// http://stackoverflow.com/questions/861409/wpf-making-hyperlinks-clickable
    /// </remarks>
    public class NavigationService
    {
        // Copied from http://geekswithblogs.net/casualjim/archive/2005/12/01/61722.aspx
        private static readonly Regex RE_URL = new Regex(@"(?#Protocol)(?:(?:ht|f)tp(?:s?)\:\/\/|~/|/)?(?#Username:Password)(?:\w+:\w+@)?(?#Subdomains)(?:(?:[-\w]+\.)+(?#TopLevel Domains)(?:com|org|net|gov|mil|biz|info|mobi|name|aero|jobs|museum|travel|[a-z]{2}))(?#Port)(?::[\d]{1,5})?(?#Directories)(?:(?:(?:/(?:[-\w~!$+|.,=]|%[a-f\d]{2})+)+|/)+|\?|#)?(?#Query)(?:(?:\?(?:[-\w~!$+|.,*:]|%[a-f\d{2}])+=(?:[-\w~!$+|.,*:=]|%[a-f\d]{2})*)(?:&(?:[-\w~!$+|.,*:]|%[a-f\d{2}])+=(?:[-\w~!$+|.,*:=]|%[a-f\d]{2})*)*)*(?#Anchor)(?:#(?:[-\w~!$+|.,*:=]|%[a-f\d]{2})*)?");

        public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached(
            "Text",
            typeof(string),
            typeof(NavigationService),
            new PropertyMetadata(null, OnTextChanged)
        );

        public static string GetText(DependencyObject d)
        { return d.GetValue(TextProperty) as string; }

        public static void SetText(DependencyObject d, string value)
        { d.SetValue(TextProperty, value); }

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var text_block = d as TextBlock;
            if (text_block == null)
                return;

            text_block.Inlines.Clear();

            var new_text = (string)e.NewValue;
            if ( string.IsNullOrEmpty(new_text) )
                return;

            var link = new Hyperlink(new Run(new_text))
            {
                NavigateUri = new Uri(new_text)
            };
            link.Click += OnUrlClick;

            text_block.Inlines.Add(link);
        }

        private static void OnUrlClick(object sender, RoutedEventArgs e)
        {
            var link = (Hyperlink)sender;

            //Что то не пашет, не разбирался
            return;
            // Do something with link.NavigateUri like:
            Process.Start(link.NavigateUri.ToString());
        }
    }
}
