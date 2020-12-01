using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o = new Employee("Amol",20000,10);
            


            Employee p = new Employee("Amol", 20000);

            Employee p1 = new Employee("Amol");

            int a=Convert.ToInt32(System.Console.ReadLine());
           
            Console.WriteLine("Net Salary = "+" "+ p1.GetNetSalary(a));



            Console.ReadLine();

        }
    }

    public class Employee {

        public Employee(string Nm, decimal sal, short dept)
        {
            NAME = Nm;
            BASIC = sal;
            DEPTNO = dept;
            EmpNo++;

            Console.WriteLine("{0} {1} {2} {3}",EmpNo, Name, sal, dept);

        }

        public Employee(string Nm, decimal sal)
        {
            NAME = Nm;
            BASIC = sal;
            EmpNo++;
            Console.WriteLine("{0} {1} {2}", EmpNo, Name, sal);
        }

        public Employee(string Nm)
        {
            NAME = Nm;
            EmpNo++;
            Console.WriteLine("{0} {1}", EmpNo, Name);
        }



        public static int EmpNo=0;
        public int id;






        

        

   
        private string Name;
        
        public string NAME {
            set {
                if (value != null) {
                    Name = value;
                }
                else {
                    Console.WriteLine("Please enter name");
                   
                }
            }

            get {

                return Name;
            }
        }

        
        private decimal Basic;

        public decimal BASIC {
            set {
                if (value < 1000000 && value > 1000) {
                    Basic =value;
                
                }
                else
                {

                    Console.WriteLine("Enter valid basic salary");
                }
            
            
            }
            get {

                return Basic;
            }
        
        }

        private short DeptNo;

        public short DEPTNO {
            set
            {

                if (value > 0)
                {
                    DeptNo = value;

                }
                else
                    Console.WriteLine("Must be greater than zero");
            }
            get {

                return DeptNo;

            }
        }

        public decimal GetNetSalary(int basee) {
            int netSalary;
            int da;
            int ta;

            da = (10 * basee) / 100;

            ta = (12 * basee) / 100;
            netSalary = basee + da + ta;

            return netSalary;
        
        }
    
    }
}
