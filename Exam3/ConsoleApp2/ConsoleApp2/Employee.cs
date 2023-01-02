using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _salary;

        public Employee(int id, string firstname, string lastName, int salary)
        {
            _id = id;
            _firstName = firstname;
            _lastName = lastName;
            _salary = salary;
        }
        public int GetId() 
        {
            return _id;
        }
        public string GetfFirstName()
        {
            return _firstName;

        }
        public string GetfLastName()
        {
            return _lastName;
        }
        public string GetName()
        {
            return   _firstName  +  _firstName ;
        }
        public int GetSalary()
        {
            return _salary;
        }
        public void SetSalary(int salary)
        {
            _salary = salary; 
        }
        public int GetAnnualSalary()
        {
            return  _salary *12;
        }
        public int  RaiseSalary(int percent)
        {
            return _salary = _salary / 100 * percent;
        }
        public override string ToString()
        {
            return $"[ id = {_id}, name = {_firstName} {_lastName}, salary = {_salary}]";
        }



    }
}
