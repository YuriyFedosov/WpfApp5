using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Графический файл (*.jpg) | *.jpg|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                var fileS = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StrokeCollection strokes = new StrokeCollection(fileS);
                InkCanvas1.Strokes = strokes;
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Графический файл (*.jpg) | *.jpg|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                var fileS = new FileStream(saveFileDialog.FileName, FileMode.Create);
                InkCanvas1.Strokes.Save(fileS);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //InkCanvas1.DefaultDrawingAttributes.Color = Colour;
            InkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
            
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Ink2.IsChecked = false;
            Ink3.IsChecked = false;
            InkCanvas1.DefaultDrawingAttributes.Color = Colors.Black;
     
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Ink1.IsChecked = false;
            Ink3.IsChecked = false;
            InkCanvas1.DefaultDrawingAttributes.Color = Colors.Red;
    
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Ink1.IsChecked = false;
            Ink2.IsChecked = false;
            InkCanvas1.DefaultDrawingAttributes.Color = Colors.Blue;
       
        }
    }
}
