using System;
//構造体
struct Mystruct
{
    public int Num;

    public Mystruct(int num)
    {
        Num = num;
    }
}

class ProgramMain
{
    static void Main()
    {
        Mystruct ms1 = new Mystruct();
        Mystruct ms2 = new Mystruct(5);
        Console.WriteLine(ms1.Num);
        Console.WriteLine(ms2.Num);
    }
}