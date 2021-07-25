using System;
using System.Collections.Generic;
using System.IO;
using Cake.Common.IO;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Build;
using Cake.Common.Tools.DotNetCore.Test;
using Cake.Coverlet;
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
        
        [TaskName("UnitTest")]
        [IsDependentOn(typeof(BuildTask))]
        public sealed class UnitTestTask : FrostingTask<BuildContext>
        {
            public override void Run(BuildContext context)
            {
                var coverletSettings = new CoverletSettings {
                    CollectCoverage = true,
                    CoverletOutputFormat = CoverletOutputFormat.lcov,
                    CoverletOutputDirectory = context.CoveragePath,
                    CoverletOutputName = Path.Combine("unit-tests"),
                    Exclude = new List<string> { "[Domain.Api*]*"},
                    ExcludeByAttribute = new List<string> { "Obsolete", "CompilerGeneratedAttribute", "GeneratedCodeAttribute"}
                };

                var unitTestsProject = Path.Combine(context.TestsPath, "Propella.UnitTests");
                
                context.DotNetCoreTest(unitTestsProject, new DotNetCoreTestSettings
                {
                    Configuration = context.MsBuildConfiguration,
                    NoBuild = true,
                }, coverletSettings);
            }
        }
        
        [TaskName("IntegrationTest")]
        [IsDependentOn(typeof(BuildTask))]
        public sealed class IntegrationTestTask : FrostingTask<BuildContext>
        {
            public override void Run(BuildContext context)
            {
                var integrationTestsProject = Path.Combine(context.TestsPath, "Propella.IntegrationTests");
                
                context.DotNetCoreTest(integrationTestsProject, new DotNetCoreTestSettings
                {
                    Configuration = context.MsBuildConfiguration,
                    NoBuild = true,
                });
            }
        }

        [IsDependentOn(typeof(UnitTestTask))]
        [IsDependentOn(typeof(IntegrationTestTask))]
        public sealed class RulAll : FrostingTask
        {
        }
    }
}
