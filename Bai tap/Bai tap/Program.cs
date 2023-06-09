using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bai_tap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khoi tao 3 student

            Student[] students = new Student[3];

            for (int i = 1; i < 4; i++)
            {
            Student std = new Student();
            Console.Write($"Nhap ten cua hoc sinh {i}: ");
                string name = Console.ReadLine();

            Console.Write($"Nhap diem Toan cua hoc sinh {i}: ");
                string diemToan =  Console.ReadLine();

            Console.Write($"Nhap diem Ly cua hoc sinh {i}: ");
                string diemLy = Console.ReadLine();

            Console.Write($"Nhap diem Hoa cua hoc sinh {i}: ");
                string diemHoa = Console.ReadLine();

            std.name = name;
            std.diemToan = int.Parse(diemToan);
            std.diemLy = int.Parse(diemLy);
            std.diemHoa = int.Parse(diemHoa);
            students[i] = std;
            }

            //In ra man hinh diem trung binh
            for ( int i = 0; i < students.Length; i++)
            {
                students[i].ShowAvg();
            }

            //In ra man hinh sv co diem tb lon nhat
             


            //Xep loai sinh vien



            Console.ReadKey();
        }
    }
}
