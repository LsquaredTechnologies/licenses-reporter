// <copyright file="MarkdownTableFormatter.cs" company="Lsquared Technologies">
// Copyright © Lsquared Technologies
// SPDX-License-Identifier: MIT
// </copyright>

using Lsquared.DotnetTools.LicensesReporter.Collectors;
using Lsquared.DotnetTools.LicensesReporter.Console;
using Lsquared.DotnetTools.LicensesReporter.Formatters;

using Microsoft.Extensions.Logging;

namespace Lsquared.DotnetTools.LicensesReporter;

internal sealed partial class MarkdownTableFormatter(ILogger<MarkdownTableFormatter> logger) : IFileOutputFormatter
{
    public string Name => "markdown-table";

    public FileInfo CreateFile(DirectoryInfo directory)
    {
        directory.Create();
        return new(Path.Combine(directory.FullName, "licenses.md"));
    }

    public async Task Write(Stream stream, IReadOnlyList<PackageLicense> packages)
    {
        IList<ColumnDefinition<PackageLicense>> columnDefinitions = [
            new("Package Name", o => o.PackageId),
            new("Package Version", o => o.PackageVersion),
            ////new("License Information Origin", o => o.LicenseOrigin, isRelevant: o => o.LicenseOrigin is not null, isEnabled: true),
            new("License", o => o.License, IsRelevant: o => o.License is not null, IsEnabled: true),
            new("License Url", o => o.LicenseUrl, IsRelevant: o => o.LicenseUrl is not null, IsEnabled: true),
            new("Copyright", o => o.Copyright, IsRelevant: o => !string.IsNullOrWhiteSpace(o.Copyright)),
            new("Authors", o => string.Join(',', o.Authors), IsRelevant: o => o.Authors.Count > 0),
            new("Project Url", o => o.ProjectUrl, IsRelevant: o => o.ProjectUrl is not null),
        ];

        foreach (var package in packages)
        {
            for (var i = 0; i < columnDefinitions.Count; ++i)
            {
                var columnDefinition = columnDefinitions[i];
                columnDefinitions[i] = columnDefinition with { IsEnabled = columnDefinition.IsEnabled || columnDefinition.IsRelevant(package) };
            }
        }

        var table = new TableWriterBuilder()
            .WithBorders(TableBorders.Markdown)
            .Build();

        using StreamWriter writer = new(stream);
        await table.Print(
            writer,
            columnDefinitions.Select(o => o.Header),
            packages,
            (package) => columnDefinitions.Select(o => o.Accessor(package)));
    }

    private sealed record class ColumnDefinition<T>(string Header, Func<T, object?> Accessor, Func<T, bool> IsRelevant, bool IsEnabled = false)
    {
        public ColumnDefinition(string header, Func<T, object?> accessor, bool isRelevant = true, bool isEnabled = true)
            : this(header, accessor, (_) => isRelevant, isEnabled)
        {
        }
    }
}
