
public  class NullForgiving
{
    public string Name { get; set; } = null!;
    public static void Run()
    {
        System.Console.WriteLine("-------NullForgiving------");
        System.Console.WriteLine("null-forgiving operator并不产生运行时检查也不改变变量的运行时值");
        System.Console.WriteLine($"null.Length也会有异常:NullReferenceException");

        NullForgiving nullForgiving=new();
        System.Console.WriteLine(nullForgiving.Name.Length);
    }
}