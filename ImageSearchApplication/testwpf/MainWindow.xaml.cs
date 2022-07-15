using FlickrNet;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetVals();
        }
        private void SetVals()
        {
            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var text = SerachTextBox.Text;
            if (string.IsNullOrEmpty(text)) return;
            var apiKey = "06cd9b6096911ff032a062e8611d467b";
            Flickr flickr = new Flickr(apiKey);
            var options = new PhotoSearchOptions { Tags = text, PerPage = 20, Page = 1 };
            PhotoCollection photos = flickr.PhotosSearch(options);


            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(
                new Uri(
                   photos[0].LargeUrl));
            myBrush.ImageSource = image.Source;
            Grid1.Background = myBrush;
        }
    }
}
