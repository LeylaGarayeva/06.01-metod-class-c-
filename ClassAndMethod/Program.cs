using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeAcademy academy       =     new CodeAcademy();

            teachers teacher_inform   =     new teachers();
             
            students student_inform   =     new students();

            reqtangel req = new reqtangel();

            teacher_inform.old = 35;

            //academy.group_name = "P502";

            academy.type = "development";

            teacher_inform.first_last_name = "Ismayil Ismayilov";

            academy.student_count = 15;

            student_inform.student_group = "P502";

            student_inform.student_name = "Leyla";

            academy.t("test message");

           // Console.WriteLine(academy.t);

            academy.all_inform();


            Console.Write("Eni:");
            req.width = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("hundurluyu:");
            req.height = int.Parse(Console.ReadLine());
            req.sahe();
            req.per();


            Console.ReadLine();
}

        }

    }


    public class CodeAcademy {

        private string group_name = "P502";
        public string type;
        public teachers teacher_name;
        public int student_count;
        public students student_info;
        public string n;
        private string test;

        public CodeAcademy()
        {
            n = group_name;
            
        }

        public void t(string k)
            {
              test = k;
            }
        public void all_inform()
        {
            Console.WriteLine("Group name: {0}, type: {1}, teacher name: {2}, student_count: {3} ",group_name,type,teacher_name,student_count);
        }

    }

    public class teachers {
        public string first_last_name;
        public string lesson_type;
        public int old;
    }

    public class students {
        public string student_name;
        public string stundent_lesson_type;
        public string student_group;

       public void st_about()
       {

           Console.WriteLine("Student group: {0} , student name: {1},  group type: {2}",student_group,student_name,stundent_lesson_type );

       }

}


public class reqtangel {
    public int width;
    public int height;
    public int sahesi;
    public int peri;

    public void sahe()
    {
        sahesi = width * height;
        Console.WriteLine("Dordbucaqlinin sahesi: {0}", sahesi);
    }

    public void per()
    {
        peri = 2*(width + height);
        Console.WriteLine("Dordbucaqlinin perimetri: {0}", peri);
    }

}

public class author {
    public string author_name;
    public string author_information;
}


public class book {
    public int page;
    public string subject;
    public author author_info;
}




