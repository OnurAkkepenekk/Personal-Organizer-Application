using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    public class Salary
    {
        private double initialSalary;
        private double experience;
        private double city;
        private double higher_education;
        private double foreign_Language_Knowledge;
        private double management_Task;
        private double Family_Status;
        public double InitialSalary { get => initialSalary; set => initialSalary = value; }
        public double Experience { get => experience; set => experience = value; }
        public double City { get => city; set => city = value; }
        public double Higher_education { get => higher_education; set => higher_education = value; }
        public double Foreign_Language_Knowledge { get => foreign_Language_Knowledge; set => foreign_Language_Knowledge = value; }
        public double Management_Task { get => management_Task; set => management_Task = value; }
        public double Family_Status1 { get => Family_Status; set => Family_Status = value; }
    }
    public abstract class SalaryBuilder
    {
        protected Salary _salary = new Salary();
        public Salary Salary
        {
            get { return _salary; }
        }
        public abstract double Hesapla();
    }
    public class UserSalaryBuilder : SalaryBuilder
    {
        public override double Hesapla()
        {
            return (_salary.InitialSalary * (_salary.Experience + _salary.City + _salary.Family_Status1 + _salary.Foreign_Language_Knowledge + _salary.Higher_education + _salary.Management_Task + 1));
        }
    }
    public class PartTimeUserSalaryBuilder : SalaryBuilder
    {
        public override double Hesapla()
        {
            return ((_salary.InitialSalary * (_salary.Experience + _salary.City + _salary.Family_Status1 + _salary.Foreign_Language_Knowledge + _salary.Higher_education + _salary.Management_Task + 1)) / 2);
        }
    }
    public class SalaryDirector
    {
        public double Calculate(SalaryBuilder vBuilder)
        {
            return (vBuilder.Hesapla());
        }
    }
}
