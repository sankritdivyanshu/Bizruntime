using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Indexers
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;
        public Employee(int Eno, string Ename, string Job, string Dname, string Location, double Salary)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
            this.Salary = Salary;


        }

        public object this[int indexer]
        {
            get
            {
                if (indexer == 1)
                    return Eno;
                else if (indexer == 2)
                    return Ename;
                else if (indexer == 3)
                    return Job;
                else if (indexer == 4)
                    return Dname;
                else if (indexer == 5)
                    return Location;
                else if (indexer == 6)
                    return Salary;
                return null;
            }
            set
            {
                if (indexer == 1)
                    Eno = (int)value;
                else if (indexer == 2)
                    Ename = (string)value;
                else if (indexer == 3)
                    Job = (string)value;
                else if (indexer == 4)
                    Dname = (string)value;
                else if (indexer == 5)
                    Location = (string)value;
                else if (indexer == 6)
                    Salary = (double)value;

            }
        }
        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "ENO")
                    return Eno;
                else if (name.ToUpper() == "ENAME")
                    return Ename;
                else if (name.ToUpper() == "JOB")
                    return Job;
                else if (name.ToUpper() == "DNAME")
                    return Dname;
                else if (name.ToUpper() == "LOCATION")
                    return Location;
                else if (name.ToUpper() == "SALARY")
                    return Salary;
                return null;
            }
            set
            {
                if (name.ToLower() == "eno")
                    Eno = (int)value;
                else if (name.ToLower() == "ename")
                    Ename =(string) value;
                else if (name.ToLower() == "job")
                     Job =(string) value;
                else if (name.ToLower() == "dname")
                    Dname =(string) value;
                else if (name.ToLower() == "location")
                    Location =(string) value;
                else if (name.ToLower() == "salary")
                     Salary =(double) value;
               
            }
        }
    }
}
     