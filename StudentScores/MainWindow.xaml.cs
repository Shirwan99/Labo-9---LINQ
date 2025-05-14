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

        private void StudentsGroupedByDepartment_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource= studentStore.GetStudentsGroupedByDepartment();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var stats = studentStore.GetStatistics();

            MessageBox.Show(
                $"Total Students: {stats.TotalStudents}\n" +
                $"Minimum Score: {stats.MinScore}\n" +
                $"Maximum Score: {stats.MaxScore}\n" +
                $"Average Score: {stats.AverageScore:F2}",
                "Student Statistics",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}
