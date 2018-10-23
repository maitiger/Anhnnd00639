using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CodeYami
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private string CurrentTag = "";
        // đợi thay Id 
        public static long currentMemberId = 00639;


        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (CurrentTag == radio.Tag.ToString())
            {
                return;
            }
            switch (radio.Tag.ToString())
            {
                case "Account":
                    CurrentTag = "Account";
                    this.MyFrame.Navigate(typeof(Menu.Account));
                    break;
                case "Register":
                    CurrentTag = "Register";
                    this.MyFrame.Navigate(typeof(Menu.Register));
                    break;
                case "MusicAnime":
                    CurrentTag = "MusicAnime";
                    this.MyFrame.Navigate(typeof(Menu.MusicAnime));
                    break;
                case "Otaku":
                    CurrentTag = "Otaku";
                    this.MyFrame.Navigate(typeof(Menu.Otaku));
                    break;

                default:
                    this.MyFrame.Navigate(typeof(Menu.Hello));
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = !this.SplitView.IsPaneOpen;
        }

        private void SplitVia_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
