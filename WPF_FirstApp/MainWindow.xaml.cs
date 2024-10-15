using System.Windows;
using System.Windows.Controls;

namespace WPF_FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<Students> studentList = new List<Students>();
        //int studentIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

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