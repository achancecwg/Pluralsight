using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo
{
    public class Employee : INotifyPropertyChanged

    {

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        private bool _wasReelected;
        public bool WasReelected
        {
            get { return _wasReelected; }
            set
            {
                _wasReelected = value;
                RaisePropertyChanged();
            }
        }

        private Party _affiliation;
        public Party Affiliation
        {
            get { return _affiliation; }
            set
            {
                _affiliation = value;
                RaisePropertyChanged();
            }
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name= "Washington", Title= "1st President of the USA", WasReelected = true, Affiliation = Party.Federalist});
            employees.Add(new Employee() { Name = "Lincoln", Title = "Honest Abe", WasReelected = true, Affiliation = Party.Independent });
            employees.Add(new Employee() { Name = "Jefferson", Title = "Who is that guy", WasReelected = true, Affiliation = Party.Democrat });
            employees.Add(new Employee() { Name = "Monroe", Title = "No, not Marilyn", WasReelected = false, Affiliation = Party.Republican });
            employees.Add(new Employee() { Name = "Jackson", Title = "He's not sorry Mrs. Jackson", WasReelected = true, Affiliation = Party.Democrat });
            return employees;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(
            [CallerMemberName] string caller= "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }

    public enum Party
    {
        Independent,
        Federalist,
        Democrat,
        Republican
    }
}
