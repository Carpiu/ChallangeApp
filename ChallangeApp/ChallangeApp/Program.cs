using ChallangeApp;
using System.Runtime.Intrinsics.X86;

Employee employee1 = new Employee("Adam", "Nowak", 32, 0);
Employee employee2 = new Employee("Monika", "Kowalska", 28, 0);
Employee employee3 = new Employee("Krystyna", "Kowalczyk", 43, 0);



employee1.AddScore(3);
employee1.AddScore(1);
employee1.AddScore(7);

employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(1);

employee3.AddScore(8);
employee3.AddScore(7);
employee3.AddScore(3);

Employee EmployeeWithMaxResoult = null;
int maxResoult = 0;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3

};




foreach (var employee in employees)
{

    if (employee.Resoult > maxResoult)
    {
        maxResoult= employee.Resoult; 
        EmployeeWithMaxResoult = employee;
    }

};


Console.WriteLine("Pracownik z największą liczbą punktów: " + "\n" + EmployeeWithMaxResoult.Name + " " + EmployeeWithMaxResoult.Surname + "\n" + "Liczba punktów: " + EmployeeWithMaxResoult.Resoult  );




