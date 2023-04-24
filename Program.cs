using EmployeeReport;
using System.Collections.Generic;
using System;
using static EmployeeReport.Employee;
using System.Linq;

class Result
{
    public string Name { get; set; }
    public List<Employee> EmployeeDetails { get; set; }
}
class Program
{

    static void Main(string[] args)
    {
        var employee = new List<Employee>();
        employee.Add(new Employee(1, "John", JobRole.Developer, new DateTime(2022, 3, 23), true, "NewYork"));
        employee.Add(new Employee(1, "John", JobRole.Developer, new DateTime(2021, 6, 23), true, "NewYork"));
        employee.Add(new Employee(2, "Jones", JobRole.SeniorDeveloper, new DateTime(2018, 5, 16), false, "NewJersey"));
        employee.Add(new Employee(3, "William", JobRole.Manager, new DateTime(2021, 4, 19), true, "LA"));
        employee.Add(new Employee(4, "Selena", JobRole.Architect, new DateTime(2021, 4, 20), false, "NewYork"));
        employee.Add(new Employee(1, "Taylor", JobRole.SeniorDeveloper, new DateTime(2018, 5, 16), true, "NewYork"));
        employee.Add(new Employee(1, "Harry", JobRole.HRManager, new DateTime(2022, 4, 21), false, "NewYork"));
        employee.Add(new Employee(1, "Shany", JobRole.HRManager, new DateTime(2022, 4, 22), true, "NewYork"));
        employee.Add(new Employee(1, "Shany", JobRole.HRManager, new DateTime(2021, 4, 4), true, "NewYork"));
        var curDate = DateTime.Now;
        //var LastYear = new DateTime(2022, 04, 21);
        //var p = new DateTime(2021, 04, 21);

        List<Result> result = new List<Result>();


        var OneToTwoYears = employee.Where(x => x.DateJoined <= curDate.AddYears(-1) && x.DateJoined >= curDate.AddYears(-2)).OrderBy(x => x.DateJoined).ToList();
        var OneToTwoYearsRW = OneToTwoYears.Where(x => x.RemoteWorking == true).ToList();
        var OneToTwoYearsNotRW = OneToTwoYears.Where(x => x.RemoteWorking == false).ToList();

        var LesThanOneYear = employee.Where(x => x.DateJoined > curDate.AddYears(-1)).ToList().OrderBy(x => x.DateJoined);
        var LesThanOneYearRW = OneToTwoYears.Where(x => x.RemoteWorking == true).ToList();
        var LesThanOneYearNotRW = OneToTwoYears.Where(x => x.RemoteWorking == false).ToList();

        var MoreThanTwoyears = employee.Where(x => x.DateJoined < curDate.AddYears(-2)).ToList().OrderBy(x => x.DateJoined);
        var MoreThanTwoyearsRW = OneToTwoYears.Where(x => x.RemoteWorking == true).ToList();
        var MoreThanTwoyearsNotRW = OneToTwoYears.Where(x => x.RemoteWorking == false).ToList();

        Console.WriteLine(OneToTwoYears);
        Console.WriteLine("Report For One To Two Years:");

        var resData = new Result();
        resData.Name = "Report For One To Two Years:";
        resData.EmployeeDetails = OneToTwoYears;
        Console.WriteLine(resData.EmployeeDetails);

        //foreach (var x in )
        //{
        //    Console.WriteLine(x.City);
        //    Console.WriteLine("satya");

        //}
        Console.ReadKey();

    }
}