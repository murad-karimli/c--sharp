using System;

namespace inheriatance
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer pr = new Programmer("Bash programch", 5000);
            pr.YekunMaash();
            Desinger ds = new Desinger("Qrafik Dizaner", 2000);
            ds.YekunMaash();
            Accountant acn = new Accountant("Bash Muhasibat", 3500);
            acn.YekunMaash();
            Financier fn = new Financier("Bash Maliyyechi", 4000);
            fn.YekunMaash();
            Marketolog ad = new Marketolog("Marketing Manager", 2500);
            ad.YekunMaash();
            Junior jn = new Junior("Junior developer", 1300);
            jn.YekunMaash();
            Senior sen = new Senior("Senior Developer", 3500);
            sen.YekunMaash();

        }
    }
}
