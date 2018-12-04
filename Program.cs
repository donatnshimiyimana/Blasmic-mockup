using System;

namespace Csharpjanet
{
    class employee
    {
        public int empId;
        public string empName;
        public string empType;
        public employee(int jId, string jName, string jType)
        {
            empId = jId;
            empName = jName;
            empType = jType;
        }
        public double payment()
        {
            if(empType == "M-E")
            {
                double t,s,r;
                int grossSalary=50000;
                t=(grossSalary*18)/100;
                s=grossSalary-t;
                r=s*3/100;
                return (s-r);


            }
            else if(empType == "T-E")
            {
                double d;
                int grossSalary=3000;
                d=grossSalary*18/100;
                return (grossSalary-d);
            } 
            else{
                double e,f,g;
                int grossSalary=1500;
                e=(grossSalary*18/100);
                f=grossSalary-e;
                g=(f*0.15)/100;
                return (g+f); 
            }           
        }
        static void Main(string[] args)
        {
            employee employee1 = new employee(1, "uwase", "M-E");
            employee employee2 = new employee(2, "uwambaye", "M-E");
            employee employee3 = new employee(3, "karisa", "T-E");
            employee employee4 = new employee(4, "viviane", "T-E");
            employee employee5 = new employee(5, "albert", "T-E");
            employee employee6 = new employee(6, "karinganire", "E-E");
            employee employee7 = new employee(7, "janet", "E-E");
            employee employee8 = new employee(8, "sylvine", "E-E");
            Console.WriteLine(employee1.payment());
            Console.WriteLine("worked by janet217080332");
        }
    }
}
