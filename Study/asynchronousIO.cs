using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    public static async Task Main()
    {
        string filePath = "file.txt";

        // ファイルに非同期で書き込みを行う
        await WriteToFileAsync(filePath, "Hello, World!");

        // 書き込み完了後にファイルを非同期で読み込む
        await ReadFromFileAsync(filePath);
    }

    public static async Task WriteToFileAsync(string filePath, string content)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            await writer.WriteAsync(content);
            await writer.FlushAsync();
        }

        Console.WriteLine("書き込み完了");
    }

    public static async Task ReadFromFileAsync(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = await reader.ReadToEndAsync();
            Console.WriteLine($"読み込んだ内容: {content}");
        }

        Console.WriteLine("読み込み完了");
    }
}
