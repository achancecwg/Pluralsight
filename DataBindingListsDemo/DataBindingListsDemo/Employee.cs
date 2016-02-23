using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingListsDemo
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public static Employee GetEmployee()
        {
            var emp = new Employee()
            {
                Name = "Tom",
                Title = "Developer"
            };
            return emp;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(caller));
            }
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name = "Washington", Title = "President" });
            employees.Add(new Employee() { Name = "Adams", Title = "Janitor" });
            employees.Add(new Employee() { Name = "Jefferson", Title = "Nurse" });
            employees.Add(new Employee() { Name = "Madison", Title = "VP of Stuff" });
            employees.Add(new Employee() { Name = "Monroe", Title = "That Guy" });
            return employees;
        }

    }
}
