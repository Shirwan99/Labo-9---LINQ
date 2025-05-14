using StudentScores.Data;
using StudentScores.Entities;
using System.Collections.Generic;
using System.Windows;

namespace StudentScores
{
    public partial class MainWindow : Window
    {
        StudentStore studentStore = new StudentStore();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowStudents_Click(object sender, RoutedEventArgs e)
        {
            Student[] allStudents = studentStore.AllStudents;
            resultListBox.ItemsSource = allStudents;

        }

        private void GeslaagdeStudenten_Click(object sender, RoutedEventArgs e)
        {
            List<Student> passedStudents = studentStore.PassedStudents;
            resultListBox.ItemsSource = passedStudents;
        }

        private void SortedByFirstName_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource= studentStore.GetStudentsSortedByFirstName();
        }
    }
}
