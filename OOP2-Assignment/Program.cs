using OOP2_Assignment;

namespace Assignment02_oop
{


    #region Q 4

    public enum SecurityPrivilege
    {

        Guest,
        Developer,
        Secretary,
        DBA

    }

    #endregion

    internal class Program
    {


        static void Main(string[] args)
        {
            #region Q ( 1 , 2 , 3 , 5 )


            Employee employee = new Employee(1, "Abdelrahman", 15000, " 10 / 3 / 1999 ", " Level 1 ", 'M');

            HiringDate hiringDate = new HiringDate(10, 3, 1999);


            Console.WriteLine(employee.ToString());


            Console.WriteLine($" Employee id            is :  {employee.Id} ");
            Console.WriteLine($" Employee Name          is :  {employee.Name} ");
            Console.WriteLine($" Employee Salary        is :  {employee.Salary} ");
            Console.WriteLine($" Employee Gender        is :  {employee.HiringDate}");
            Console.WriteLine($" Employee SecurityLevel is :  {employee.SecurityLevel}");
            Console.WriteLine($" Employee Gender        is :  {employee.Gender} ");


            #endregion



        }
    }
}
