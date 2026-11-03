// 1. 引用记录
public record RefRecord(string number,string name);

// 2. 值记录（不要加 readonly，校验问题 4 要验证它能否赋值）
public record struct ValueRecord(string number,string name);

// 普通类
public class PlainClass
{
    public PlainClass(string number,string name)
    {
        this.Number=number;
        this.Name=name;
    }

    public string Number {get;}

    public string Name {get;}
}

public static class RecordEquality{
    public static void Run()
    {
        System.Console.WriteLine("===========相等性研究=============");
        var p1=new PlainClass("P1","张三");
        var p2=new PlainClass("P1","张三");
        Console.WriteLine($"PlainClass         p1==p2    : {p1==p2}");
        System.Console.WriteLine($"PlainClass  Equals : {p1.Equals(p2)}");
        System.Console.WriteLine($"PlainClass 引用相同 ：{ReferenceEquals(p1,p2)}");
        System.Console.WriteLine($"PlainClass HashCode p1: {p1.GetHashCode()} p2：{p2.GetHashCode()}");

        var v1=new ValueRecord("P1","张三");
        var v2=new ValueRecord("P1","张三");
        System.Console.WriteLine($"ValueRecord      ==     ：{v1==v2}");
        System.Console.WriteLine($"ValueRecord      Equals ： {v1.Equals(v2)}");
        System.Console.WriteLine($"objects.Equals 静态调用 ：{object.Equals(v1,v2)}");
        System.Console.WriteLine($"HashSet 元素数          ：{new HashSet<ValueRecord>{v1,v2}.Count}");
        
        System.Console.WriteLine($"ValueRecord 支持修改属性值，修改前：{v1}");
        v1.number="P2"; 
        System.Console.WriteLine($"ValueRecord 支持修改属性值，修改后：{v1}");


        var r1=new RefRecord("P1","张三");
        var r2=new RefRecord("P1","张三");
        var r3=r1 with{name="李四"};
        System.Console.WriteLine($"RefRecord  r1==r2 ：{r1==r2}");
        System.Console.WriteLine($"RefRecord  r1==r3 ：{r1==r3}");
    }
}
