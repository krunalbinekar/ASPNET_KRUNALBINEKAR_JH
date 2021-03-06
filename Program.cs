using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            GeneralManager o = new GeneralManager("krunal",20000,20,"COMPUTER","20",20000);
            GeneralManager o1 = new GeneralManager("krunal", 20000, 20, "COMPUTER", "20", 20000);
            GeneralManager o2 = new GeneralManager("krunal", 20000, 20, "COMPUTER", "20", 20000);

            Console.ReadLine();


        }
    }

    public abstract class Employee {

        public Employee(string NAME,decimal BASIC,short DEPTNO ) {
            //EmpNo++;
            this.NAME = NAME;
            this.BASIC = BASIC;
            this.DEPTNO = DEPTNO;


        
        }

        private string Name;

        public string NAME {

            set {
                if (value!=null && value!="")
                    value = Name;
                else
                    Console.WriteLine("Should not be blank");
                        }

            get {
                return Name;
            }
        
        }

       public static int EmpNo=1;

        public int EMPNO { get;  }

        private short deptno;
        public short DEPTNO {
            set {
                if (value > 0)
                {
                    value = deptno;
                }
                else {
                    Console.WriteLine("0 is not allowed");
                }
            
            }

            get {

                return deptno;

            }
        
        }


        public abstract decimal BASIC { set; get; }

        public abstract decimal CalcNetSalary();
    }

    public class Manager : Employee{
        public Manager (string NAME, decimal BASIC, short DEPTNO,string DESGIGNATION,decimal NET) : base(NAME,BASIC,DEPTNO)
        {
            //EmpNo++;
            //this.NAME = NAME;
            //this.BASIC = BASIC;
            //this.DEPTNO = DEPTNO;
            this.DESIGNATION = DESGIGNATION;
            decimal Net = CalcNetSalary();
            NET = Net;

            Console.WriteLine("{0} {1} {2} {3} {4} {5}",EmpNo,NAME,BASIC,DEPTNO,DESGIGNATION,NET);
        }


        private string Designation;
        public string DESIGNATION {
            set {
                if (value != null && value != "")
                    value = Designation;
                else
                    Console.WriteLine("Cannot be blank");
            }

            get {

                return Designation;

            }
        }

        private decimal Basic;
        public override decimal BASIC {
            set
            {
                if (value < 1000000 && value > 1000)
                {
                    Basic = value;

                }
                else
                {

                    Console.WriteLine("Enter valid basic salary");
                }


            }
            get
            {

                return Basic;
            }

        }

        public override decimal CalcNetSalary()
        {
            decimal basee = BASIC;
            decimal netSalary;
            decimal da;
            decimal ta;

            da = (10 * basee) / 100;

            ta = (12 * basee) / 100;
            netSalary = basee + da + ta;

            return netSalary;
        }

    }
    public class GeneralManager : Manager {
        public GeneralManager(string NAME, decimal BASIC, short DEPTNO, string DESGIGNATION,string PERKS,decimal NET) : base(NAME,BASIC,DEPTNO,DESGIGNATION,NET)
        {
            EmpNo++;
            //this.NAME = NAME;
            //this.BASIC = BASIC;
            //this.DEPTNO = DEPTNO;
            //this.DESIGNATION = DESGIGNATION;
            this.PERKS = PERKS;
            //decimal Net = CalcNetSalary();
            //NET = Net;
        }
        private string perks;

        public string PERKS {
            set {
                value = perks;
            }

            get {
                return perks;

            }
        
        }
        public override decimal CalcNetSalary()
        {
            decimal basee = BASIC;
            decimal netSalary;
            decimal da;
            decimal ta;

            da = (10 * basee) / 100;

            ta = (12 * basee) / 100;
            netSalary = basee + da + ta;

            return netSalary;
        }


    }

    public class CEO : Employee
    {
        public CEO(string NAME, decimal BASIC, short DEPTNO) : base(NAME, BASIC, DEPTNO)
        {
            EmpNo++;
            this.NAME = NAME;
            this.BASIC = BASIC;
            this.DEPTNO = DEPTNO;
            //this.DESIGNATION = DESGIGNATION;
        }
        public sealed override decimal BASIC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public sealed override decimal CalcNetSalary()
        {
            throw new NotImplementedException();
        }
    }

}

