namespace DotnetLab.Core.Samples;

public record Patient(string Id,string Name,DateOnly BirthDate);

public static class RecordBasics
{
    public static void Run()
    {
        System.Console.WriteLine("===========record类型基础知识=============");
        // 2. 造对象：直接传参，和调构造函数一样
        var patient=new Patient("P0001","FreeLoop",new DateOnly(1995,1,1));
        Console.WriteLine($"修改前原对象：{patient}");
        // 无法通过实例.属性方式修改属性值，会报异常error CS8852: 只能在对象初始值设定项中或 在实例构造函数或 "init" 访问器中的 "this" 或 "base" 上分配 init-only 属性或索引器 "Patient.Name"。
        // patient.Name="张三";

        // 3. with：复制一份并改指定属性（原来那堆"复制并改字段"的方法不用了）
        var patientB=patient with{Name="Dainel"};
        Console.WriteLine($"修改后原对象：{patient}");
        Console.WriteLine($"新对象：{patientB}");
        // 4. 解构：按定义顺序拆开
        var(id,name,birth)=patientB;
        Console.WriteLine($"{id},{name},{birth}");
    }
}



