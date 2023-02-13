namespace EmployeeManagermentSystem
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool Login (string userName,string password)
        {
            if(userName=="Shivam" && password == "pass=1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee GetEmployee(string name)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Shivam", Id = 1, Dept = "training" });
            employees.Add(new Employee() { Name = "Kamal", Id = 2, Dept = "IT" });
            employees.Add(new Employee() { Name = "Shisthi", Id = 3, Dept = "IT" });
            employees.Add(new Employee() { Name = "Vikash", Id = 4, Dept = "Development" });
            return employees.FirstOrDefault(t => t.Name == name);
            
        }
    }
}