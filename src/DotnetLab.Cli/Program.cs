using DotnetLab.Core.Samples;

/// record 引用记录基本知识：
/// 1. 属性较少可直接通过一行定义创建引用记录，省略属性声明、
/// 2. 无法通过实例.属性方式修改属性值，会报异常
/// 3. 可以通过with 函数复制实例并修改指定属性
/// 4. record相等性判断是值相等判断，只要所有属性值一样就相等，不是引用相等比较
/// 5. 还可以通过析构函数按顺序获取到所有属性，这是目前很多高级语言的现代化写法（如vue）
RecordBasics.Run();

/// record/record struct/class 比较
/// 1. class默认是值相等比较，除非重写 Equals/==/!=/GetHashcode四件套
/// 2. record/record struct一个是引用类型，一个是值类型，存放位置不一样，同时值类型可通过实例.属性方式修改属性值
/// 3. record/record struct都是值相等比较
RecordEquality.Run();

/// init/required
/// init-让属性只能在构造函数内或对象初始化器{Name="..."}内赋值，其余地方赋值编译错误（CS8852）
/// required-强调调用方实例化时必须给属性赋值，否则无法编译通过。没搭配init而是用set时可以通过实例.属性名赋值修改
/// required 可以用在普通class/struct上，不只是record
InitAndRequiredClass.Run();

/// 通过类文件的Nullable，可以将null检查从运行时提前到编译器，
/// 若想跳过这个检查，可以在类型后增加 ?，但在用的时候调用者需要检查
/// - string? 和 string 编译后是同一个类型
/// 它全部的价值在编译期警告/错误，以及在元数据里留一个标记（供其他项目读取）。
/// 流分析是路径敏感的，不是"赋过值就安全"
NullableFlow.Run(null);
NullableFlow.Run("");
NullableFlow.Run(" ");

/// 总有一些场景，编译器无法验证但你确知安全：
NullForgiving.Run();