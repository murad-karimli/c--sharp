using System;
using System.Collections.Generic;
using System.Text;

namespace inheriatance
{
    class Shirket
    {
        protected double salary;
        protected string position;

        public Shirket(string Position,double Salary)
        {
            position=Position;
            salary=Salary;
        }

        public virtual double GelirVergisi(double PSalary)
        {
            salary=PSalary;
            double vergi;
            if (PSalary < 2500)
            {
                vergi = (salary - 200) * 0.14;
            }
            else
            {
                vergi = (salary - 2500) * 0.25;
            }
            return vergi;
        }
        public double DSMF(double DSalary)
        {
            salary = DSalary;
            return salary * 0.03; ;
        }
        public double TibbiSigorta(double TSalary)
        {
            salary = TSalary;
            double faiz;
            if(salary<8000)
            {
                faiz = salary * 0.02;
            }
            else
            {
                faiz = salary * 0.005;
            }
            return faiz;
        }

    }
    class ItDepartment : Shirket
    {

        public ItDepartment(string ITPosition, double ITSalary):base(ITPosition ,ITSalary)
        {
            position = ITPosition;
            salary = ITSalary;
        }
    }
    class Programmer:ItDepartment
    {
        public Programmer (string ProgrammerPosition, double ProgrammerSalary):base(ProgrammerPosition,ProgrammerSalary)
        {
            salary = ProgrammerSalary;
            position = ProgrammerPosition;
        }

        public override double GelirVergisi(double PSalary)
        {
            salary = PSalary;
            double vergi;
            if (salary < 2500)
            {
                vergi = (salary - 200) * 0.12;
            }
            else
            {
                vergi = (salary - 2500) * 0.22;
            }
            return vergi; 
        }
        public void YekunMaash()
        {
            Console.WriteLine($"{salary - (DSMF(salary) + TibbiSigorta(salary) + GelirVergisi(salary))}  is salary of {position}");
        }
    }
    class Junior : Programmer
    {
        public Junior(string JuniorPosition, double JuniorSalary) : base(JuniorPosition, JuniorSalary)
        {
            salary = JuniorSalary;
            position = JuniorPosition;
        }
        public override double GelirVergisi(double PSalary)
        {
            salary = PSalary;
            double vergi;
            if (salary < 2500)
            {
                vergi = (salary - 200) * 0.1;
           }
            else
            {
                vergi = (salary - 2500) * 0.2;
            }
            return vergi;
        }
       
    }
    class Senior : Programmer
    {
        public Senior(string SeniorPosition, double SeniorSalary) : base(SeniorPosition, SeniorSalary)
        {
            salary = SeniorSalary;
            position = SeniorPosition;
        }
        public override double GelirVergisi(double PSalary)
        {
            salary = PSalary;
            double vergi;
            if (salary < 2500)
            {
                vergi = (salary - 200) * 0.15;
            }
            else
            {
                vergi = (salary - 2500) * 0.24;
            }
            return vergi;
        }

    }

    class Desinger : ItDepartment
    {
        public Desinger(string DesingerPosition, double DesingerSalary) : base(DesingerPosition, DesingerSalary)
        {
            salary = DesingerSalary;
            position = DesingerPosition;
        }

        public override double GelirVergisi(double PSalary)
        {
            salary = PSalary;
            double vergi;
            if (salary < 2500)
            {
                vergi = (salary - 200) * 0.12;
            }
            else
            {
                vergi = (salary - 2500) * 0.22;
            }
            return vergi;
        }
        public void YekunMaash()
        {
            Console.WriteLine($"{salary - (DSMF(salary) + TibbiSigorta(salary) + GelirVergisi(salary))}  is salary of {position}");
        }
    }
    class Finance : Shirket
    {
            
        public Finance (string FPosition, double FSalary):base(FPosition, FSalary)
        {
            salary = FSalary;
            position = FPosition;
        }
        public override double GelirVergisi(double PSalary)
        {
            salary = PSalary;
            double vergi;
            if (salary < 2500)
            {
                vergi = (salary - 200) * 0.16;
            }
            else
            {
                vergi = (salary - 2500) * 0.27;
            }
            return vergi;
        }
    }
    class Financier : Finance
    {

        public Financier(string FinancierPosition, double FinancierSalary) : base(FinancierPosition, FinancierSalary)
        {
            salary = FinancierSalary;
            position = FinancierPosition;
        }
        public override double GelirVergisi(double PSalary)
        {
            salary = PSalary;
            double vergi;
            if (salary < 2500)
            {
                vergi = (salary - 200) * 0.16;
            }
            else
            {
                vergi = (salary - 2500) * 0.27;
            }
            return vergi;
        }
        public void YekunMaash()
        {
            Console.WriteLine($"{salary - (DSMF(salary) + TibbiSigorta(salary) + GelirVergisi(salary))}  is salary of {position}");
        }
    }

    class Accountant : Finance
    {

        public Accountant(string AccountantPosition, double AccountantSalary) : base(AccountantPosition, AccountantSalary)
        {
            salary = AccountantSalary;
            position = AccountantPosition;
        }
        public override double GelirVergisi(double PSalary)
        {
            salary = PSalary;
            double vergi;
            if (salary < 2500)
            {
                vergi = (salary - 200) * 0.11;
            }
            else
            {
                vergi = (salary - 2500) * 0.23;
            }
            return vergi;
        }
        public void YekunMaash()
        {
            Console.WriteLine($"{salary - (DSMF(salary) + TibbiSigorta(salary) +GelirVergisi(salary))}  is salary of {position}");
        }
    }
    class AdvertisingDepartment : Shirket
    {
        public AdvertisingDepartment(string AdvertisingPosition, double AdvertisingSalary) : base(AdvertisingPosition, AdvertisingSalary)
        {
            position = AdvertisingPosition;
            salary = AdvertisingSalary;
        }
    }
    class Marketolog : AdvertisingDepartment
    {
        public Marketolog(string MarketologPosition, double MarketologSalary) : base(MarketologPosition, MarketologSalary)
        {
            salary = MarketologSalary;
            position = MarketologPosition;
        }

        public override double GelirVergisi(double PSalary)
        {
            salary = PSalary;
            double vergi;
            if (salary < 2500)
            {
                vergi = (salary - 200) * 0.11;
            }
            else
            {
                vergi = (salary - 2500) * 0.23;
            }
            return vergi;
        }
        public void YekunMaash()
        {
            Console.WriteLine($"{salary - (DSMF(salary) + TibbiSigorta(salary) + GelirVergisi(salary))}  is salary of {position}");
        }
    }
}


