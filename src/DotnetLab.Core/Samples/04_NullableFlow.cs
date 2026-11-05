namespace DotnetLab.Core.Samples;
public static class NullableFlow
{
    public static void Run(string? input)
    {
        System.Console.WriteLine("-----------NullableFlow--------------");
        //string name=null; //将 null 文本或可能的 null 值转换为不可为 null 类型。
        string? name=null; // 不报错、

        if(name!=null)
        {
            
        }
        

        System.Console.WriteLine($"input=={input}");
        if (!string.IsNullOrEmpty(input))
        {
            System.Console.WriteLine($"string.IsNullOrEmpty{input.Trim()}"); 
        }
        
        if (!string.IsNullOrWhiteSpace(input))
        {
            System.Console.WriteLine($"string.IsNullOrWhiteSpace{input.Trim()}"); 
        }
    }
}