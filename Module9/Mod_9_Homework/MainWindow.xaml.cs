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

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = txtFirstName.Text;
            student1.LastName = txtLastName.Text;
            student1.City = txtCity.Text;
            Student.students.Add(student1);
            Student.count += 1;
            MessageBox.Show("Student created!");
            ClearText();
        }

        private void ClearText()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (Student.count > 0)
            {
                foreach (var st in Student.students)
                {
                    MessageBox.Show($"Student's name: {st.FirstName} {st.LastName}\nStudent's city: {st.City}");
                }
            }
            else MessageBox.Show("No students created!");
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (Student.count > 0)
            {
                foreach (var st in Student.students)
                {
                    MessageBox.Show($"Student's name: {st.FirstName} {st.LastName}\nStudent's city: {st.City}");
                }
            }
            else MessageBox.Show("No students created!");
        }
    }
}