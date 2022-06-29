using System.Collections.ObjectModel;

namespace WpfDataGridHorizontal
{
    public class ViewModel
    {
        private RelayCommand _addItemCommand;
        public ObservableCollection<Employee> Employees { get;}
        public RelayCommand AddItemCommand
        {
            get
            {
                return _addItemCommand ?? (_addItemCommand = new RelayCommand(o =>
                    Employees.Add(new Employee {Id = 1000, Name = "New", Department = "Student", Location = "BLR"})));
            }
            
        }

        public ViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee() { Id = 101, Name = "John", Department = "Dev Tools", Location = "US" });
            Employees.Add(new Employee() { Id = 102, Name = "Mike", Department = "Development", Location = "UK" });
            Employees.Add(new Employee() { Id = 103, Name = "Fuller", Department = "R&D", Location = "US" });
            Employees.Add(new Employee() { Id = 104, Name = "Lilly", Department = "HR", Location = "Japan" });
            Employees.Add(new Employee() { Id = 105, Name = "Prabhat", Department = "Accounts", Location = "India" });
            Employees.Add(new Employee() { Id = 106, Name = "Richa", Department = "HR", Location = "India" });
            Employees.Add(new Employee() { Id = 107, Name = "Miller", Department = "Dev Tools", Location = "US" });
            Employees.Add(new Employee() { Id = 108, Name = "Sam", Department = "Dev Tools", Location = "UK" });
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
    }
}