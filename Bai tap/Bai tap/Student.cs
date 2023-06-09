using System;

public class Student
{
    public string name = "";
    public int diemToan;
    public int diemLy;
    public int diemHoa;
    public float dtb;

    public Student()
    {
    }

    public Student(string name, int diemToan, int diemLy, int diemHoa)
    {
        this.name = name;
        this.diemToan = diemToan;
        this.diemLy = diemLy;
        this.diemHoa = diemHoa;
        //this.dtb = (diemToan + diemLy + diemHoa) / 3;
    }

    public void ShowAvg()
    {
        this.dtb = (diemHoa + diemLy + diemToan) / 3;
        Console.WriteLine("Diem trung binh cua " + name + " la: " + dtb);
    }
}
