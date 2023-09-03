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

//クラス
class Myclass
{
    public int Num;

    public Myclass(int num)
    {
        Num = num;
    }
}

static void MS(Mystruct ms)
{
    ms *= 2;
}

static void MC(Myclass mc)
{
    mc *= 2;
}
