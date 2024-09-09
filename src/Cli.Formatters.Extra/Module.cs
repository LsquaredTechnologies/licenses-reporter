// <copyright file="Module.cs" company="Lsquared Technologies">
// Copyright © Lsquared Technologies
// SPDX-License-Identifier: MIT
// </copyright>

using System.Runtime.CompilerServices;

using Lsquared.DotnetLicensesReporter.Formatters;

namespace Lsquared.DotnetLicensesReporter;

internal static class Module
{
    [ModuleInitializer]
    public static void Initialize()
    {
        OutputFormats.Add("yaml");
        OutputFormats.Add("html-list");
        OutputFormats.Add("html-table");
        OutputFormats.Add("template");
    }
}
