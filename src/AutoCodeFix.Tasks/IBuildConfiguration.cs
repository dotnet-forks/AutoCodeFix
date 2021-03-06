﻿using System.Collections.Generic;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace AutoCodeFix
{
    internal interface IBuildConfiguration
    {
        IBuildEngine4 BuildEngine4 { get; }

        bool BuildingInsideVisualStudio { get; }

        IDictionary<string, string> GlobalProperties { get; }

        ITaskItem[] Analyzers { get; }

        string MSBuildBinPath { get; }

        string ToolsPath { get; }

        bool DebugProjectReader { get; }

        TaskLoggingHelper Log { get; }
    }
}
