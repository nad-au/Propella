using System.IO;
using Build;
using Cake.Common;
using Cake.Core;
using Cake.Frosting;

public static class Program
{
    public static int Main(string[] args) {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

public class BuildContext : FrostingContext
{
    public string MsBuildConfiguration { get; set; }
    public string SourcePath { get; set; }
    public string SolutionPath { get; set; }
    
    public BuildContext(ICakeContext context)
        : base(context) {
        MsBuildConfiguration = context.Argument("configuration", "Debug");
        SourcePath = "../../src";
        SolutionPath = Path.Combine(SourcePath, "Propella.sln");
    }
}

[TaskName("Default")]
[IsDependentOn(typeof(BuildTasks.RulAll))]
public class DefaultTask : FrostingTask
{
}