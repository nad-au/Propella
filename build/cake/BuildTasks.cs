using System.IO;
using Cake.Common.IO;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Build;
using Cake.Common.Tools.DotNetCore.Test;
using Cake.Frosting;

namespace Build
{
    /// <summary>
    ///     This is an example to implement similar functionality of create-test-environment.sh
    /// </summary>
    public sealed class BuildTasks
    {
        [TaskName("Clean")]
        public sealed class CleanTask : FrostingTask<BuildContext>
        {
            public override void Run(BuildContext context)
            {
                var binPath = Path.Combine(context.SourcePath, $"Propella.Api/bin/{context.MsBuildConfiguration}");
                context.CleanDirectory(binPath);
            }
        }

        [TaskName("Build")]
        [IsDependentOn(typeof(CleanTask))]
        public sealed class BuildTask : FrostingTask<BuildContext>
        {
            public override void Run(BuildContext context)
            {
                context.DotNetCoreBuild(context.SolutionPath, new DotNetCoreBuildSettings
                {
                    Configuration = context.MsBuildConfiguration,
                });
            }
        }
        
        [TaskName("Test")]
        [IsDependentOn(typeof(BuildTask))]
        public sealed class TestTask : FrostingTask<BuildContext>
        {
            public override void Run(BuildContext context)
            {
                context.DotNetCoreTest(context.SolutionPath, new DotNetCoreTestSettings
                {
                    Configuration = context.MsBuildConfiguration,
                    NoBuild = true,
                });
            }
        }
        
        [IsDependentOn(typeof(TestTask))]
        public sealed class RulAll : FrostingTask
        {
        }
    }
}
