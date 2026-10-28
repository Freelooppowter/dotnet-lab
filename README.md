# dotnet-lab

.NET 现代写法练习与迁移实验场。

## 这是什么

记录从 .NET Framework 时代写法迁移到 .NET 现代写法的过程，每个示例都可运行、可测试。

## 结构

```
dotnet-lab/
├── src/
│   └── DotnetLab.Core/        类库：语法示例与练习代码
├── tests/
│   └── DotnetLab.Tests/       xUnit 测试
├── notes/                     周记与踩坑记录
├── Directory.Build.props      全仓库统一编译配置
├── global.json                锁定 SDK 版本
└── NuGet.config               固定包源，避免受机器环境影响
```

## 环境

| 项目 | 值 |
|---|---|
| .NET SDK | 10.0.403（由 `global.json` 锁定） |
| 目标框架 | `net10.0` |
| 解决方案格式 | `.slnx`（.NET 10 新的 XML 格式） |

## 怎么跑

```bash
dotnet build
dotnet test
dotnet format --verify-no-changes
```

## 几条约定

- **`TreatWarningsAsErrors` 不在本地整体开启**，但 `nullable` 单独升级为错误——性价比最高的一个设置，拦的是运行时 `NullReferenceException`。
- **CI 环境自动严格**：`Directory.Build.props` 里有 `Condition="'$(CI)' == 'true'"` 分支，GitHub Actions 里警告即错误，本地不受影响。
- **`NuGet.config` 用 `<clear />` 清空继承源**，只留华为镜像与官方源。原因：机器级配置里残留的镜像地址已失效（返回 404），会导致包恢复长时间卡住。

## 进度

- [x] W1 环境搭建与仓库骨架
- [ ] W1 现代 C# 语法示例 15 例
- [ ] W2 单元测试体系
- [ ] W4 async 与 WinForm 八个坑

## 说明

所有代码均为个人练习，与任职公司项目无关；不含任何真实业务数据或商业代码。
