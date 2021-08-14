using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
    class Student
    {
        int regno { get; set; }
        string name { get; set; }
        public Student(int l_regno, string l_name)
        {
            regno = l_regno;
            name = l_name;
        }
        public override string ToString()
        {
            return $"Regno:{regno}\n Name:{name}";
        }
    }
    class science : Student
    {
        float phy { get; set; }
        float chem { get; set; }
        float maths { get; set; }
        float avg { get; set; }
        public science(int l_regno, string l_name, float l_phy, float l_chem, float l_maths) : base(l_regno, l_name)
        {
            phy = l_phy;
            chem = l_chem;
            maths = l_maths;
        }
        public override string ToString()
        {
            avg = (phy + maths + chem) / 3;
            return base.ToString() + $"\nMarks obtained:\n" +
                $"Physics:{phy}\nChemistry:{chem}\nMaths:{maths}\n" +
                $"With an average of {avg}";
        }




    }
    class commerce : Student
    {
        float economics { get; set; }
        float accounts { get; set; }
        float banking{ get; set; }
        float avg{ get; set; }
        public commerce(int l_regno, string l_name, float l_economics, float l_accounts, float l_banking) : base(l_regno, l_name)
        {
            economics = l_economics;
            accounts = l_accounts;
            banking = l_banking;
        }
        public override string ToString()
        {
            this.avg = (economics + accounts + banking) / 3;
            return base.ToString() + $"\nMarks obtained:\n" +
                $"Economics:{economics}\nAccounts:{accounts}\nBanking:{banking}\n" +
                $"With an average of {avg}";
        }
    }
    class Program3
    {
        public static void Main()
        {
            science s = new science(10, "Sankarshana", 90, 90, 95);
            commerce c = new commerce(20, "Sachin", 90, 80, 85);
            Console.WriteLine(s.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
