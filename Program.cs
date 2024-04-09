internal class Program
{
    private static void Main(string[] args)
    {
        string[] myStudent = {"Mai", "dung", "Minh", "Linh", "Hieu", "Toan", "Hung"};
        Console.WriteLine("Nhap 1 cai ten tu ban phim");
        string name = Console.ReadLine();
        bool isHas = false;
        for (int i = 0; i < myStudent.Length; i++)
        {
            if (myStudent[i].Equals(name))
            {
                Console.WriteLine("Co sinh vien o trong lop");
                isHas = true;
                break;
            }
        }
        if (!isHas)
        {
            Console.WriteLine("Khong co sinh vien trong lop");
        }
    }
}