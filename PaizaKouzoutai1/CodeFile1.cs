using System;

struct User
{
    string name;
    int old;
    string birth;
    string state;

    public User(string name, int old, string birth, string state)
    {
        this.name = name;
        this.old = old;
        this.birth = birth;
        this.state = state;
    }

    public void Output()
    {     //メソッド名は基本大文字
        Console.WriteLine("User{");
        Console.WriteLine($"nickname : {name}");
        Console.WriteLine($"old : {old}");
        Console.WriteLine($"birth : {birth}");
        Console.WriteLine($"state : {state}");
        Console.Write("}");
    }
}


class Program
{

    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var num = int.Parse(Console.ReadLine());//入力される文字列は基本文字列型で取得しているみたい。

        for (int i = 0; i < num; i++)
        {
            var line = Console.ReadLine();
            String[] data = line.Split(' ');//やからこれもあり。
            string name = data[0];
            int old = int.Parse(data[1]);
            string birth = data[2];
            string state = data[3];
            User us = new User(name, old, birth, state);
            us.Output();
        }

    }
}