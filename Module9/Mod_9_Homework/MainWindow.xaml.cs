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

namespace Module9
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

        Student student1 = new Student();

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            FillText(student1);
            student1.Students.Add(student1);
            student1.Count += 1;
            MessageBox.Show("Student created!");
            ClearText();
        }

        private void FillText(Student student1)
        {
            student1.FirstName = txtFirstName.Text;
            student1.LastName = txtLastName.Text;
            student1.City = txtCity.Text;
        }

        private void ClearText()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (student1.Count > 0)
            {
                foreach (var st in student1.Students)
                {
                    MessageBox.Show($"Student's name: {st.FirstName} {st.LastName}\nStudent's city: {st.City}");
                }
            }
            else MessageBox.Show("No students created!");
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (student1.Count > 0)
            {
                foreach (var st in student1.Students)
                {
                    MessageBox.Show($"Student's name: {st.FirstName} {st.LastName}\nStudent's city: {st.City}");
                }
            }
            else MessageBox.Show("No students created!");
        }
    }
}