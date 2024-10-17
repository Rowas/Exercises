using Microsoft.Win32;
using System.ComponentModel;
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
using System;
using System.IO;
using System.Reflection.Metadata;

namespace Exercises_DiagBoxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_New(object sender, RoutedEventArgs e)
        {
            txtEditor.IsEnabled = true;
            PrimaryWindow.Title = "Untitled Document";
            PrimaryWindow.Title = PrimaryWindow.Title.Trim('*');
            if (PrimaryWindow.Title.Contains("*")) { ShowDialog(); }
            txtEditor.Text = txtEditor.Text.Remove(0);
        }

        private void MenuItem_Click_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            PrimaryWindow.Title = (string)openFileDialog.SafeFileName;
            txtEditor.IsEnabled = true;
        }

        private void MenuItem_Click_Save(Object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            PrimaryWindow.Title = (string)saveFileDialog.SafeFileName;
        }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            ShowDialog();
            if (DialogResult.Value != null) { Environment.Exit(0); }
        }

        private void txtEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PrimaryWindow.Title.Contains("*")) { }
            else { PrimaryWindow.Title = PrimaryWindow.Title + "*"; }
            if (txtEditor.Text.Length <= 0) { PrimaryWindow.Title.Trim('*'); }
        }
    }
}