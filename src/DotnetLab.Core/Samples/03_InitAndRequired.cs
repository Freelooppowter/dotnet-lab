namespace DotnetLab.Core.Samples;
public record ReportTemplate
{
    public string Id{get;init;}="P002";
    public required string Name{get;init;}
    public required string Content{get;set;}
    public string? Body{get;set;}
}

public struct LocationOfMouse
{
    public required float OffsetOfX{get;init;}
    public required float OffsetOfY{get;init;}
}

public static class InitAndRequiredClass
{
    public static void Run()
    {
        System.Console.WriteLine("-----------InitAndRequired---------------");
        ReportTemplate rp=new ReportTemplate{Name="超声内镜报告",Id="P01",Content="实例化时必须赋值"};
        Console.WriteLine($"修改前报告模板原对象：{rp}");
        // dotnet build报错：error CS8852: 只能在对象初始值设定项中或 在实例构造函数或 "init" 访问器中的 "this" 或 "base" 上分配 init-only 属性或索引器 "ReportTemplate.Name"。
        // rp.Name="更新后名称";
        rp.Body="所见+印象";
        Console.WriteLine($"修改后报告模板原对象：{rp}");

        // dotnet build报错：必须在对象初始值设定项或属性构造函数中设置所需的成员'ReportTemplate.Name'。
        // ReportTemplate rp1=new ReportTemplate();

        // dotnet build报错：error CS8852: 只能在对象初始值设定项中或 在实例构造函数或 "init" 访问器中的 "this" 或 "base" 上分配 init-only 属性或索引器 "ReportTemplate.Name"。
        // rp.Name="更新后名称";
    }
}

