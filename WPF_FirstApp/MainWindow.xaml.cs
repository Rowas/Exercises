using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<Students> studentList = new List<Students>();
        //int studentIndex = 0;

        int clicks = 0;
        public MainWindow()
        {
            InitializeComponent();
        }



        //private void ClickButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ClickButton.Content = $"Clicks: {clicks++}";
        //}


        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    lableToChange.Content = NewLable.Text;
        //    comboBox.Items.Add(NewLable2.Text);
        //}

        //private void NewLable2_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    ChangeButton.Content = NewLable2.Text;
        //}

        //private void NewLable_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        //{
        //    if (e.Key == Key.Enter)
        //        { lableToChange.Content = NewLable.Text; }
        //}

        //private void DisableButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (DisableButton.IsChecked == true)
        //    {
        //        ChangeButton.IsEnabled = true;
        //        return;
        //    }
        //    ChangeButton.IsEnabled = false;


        //    private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        Button button = (sender as Button);
        //        studentList.Add(new Students(firstName.Text.ToString(), lastName.Text.ToString(), mailBox.Text.ToString(), studentIndex++));
        //        studentBox.Items.Add($"{firstName.Text} {lastName.Text}");
        //        firstName.Clear(); lastName.Clear(); mailBox.Clear();
        //    }
        //}
        //class Students
        //{
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }
        //    public string Email { get; set; }
        //    public int Index { get; set; }

        //    public Students()
        //    {

        //    }

        //    public Students(string firstName, string lastName, string email, int index)
        //    {
        //        Index = index;
        //        FirstName = firstName;
        //        LastName = lastName;
        //        Email = email;
        //    }
    }
}