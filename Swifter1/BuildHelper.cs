using System;
using System.Diagnostics;
using System.IO;

namespace Swifter1
{
    public static class BuildHelper
    {
        /// <summary>
        /// Runs `dotnet build` on the given SDK‑style project file.
        /// Returns true on success; on failure, outLog contains both stdout+stderr.
        /// </summary>
        public static bool RebuildProject(string projectFilePath, out string outLog)
        {
            if (!File.Exists(projectFilePath))
                throw new FileNotFoundException("Project file not found", projectFilePath);

            // We run 'dotnet build' in the folder containing the .csproj
            var projectDir = Path.GetDirectoryName(projectFilePath)!;

            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"build \"{projectFilePath}\" --configuration Debug --no-incremental",
                WorkingDirectory = projectDir,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var proc = Process.Start(psi)!;
            string stdOut = proc.StandardOutput.ReadToEnd();
            string stdErr = proc.StandardError.ReadToEnd();
            proc.WaitForExit();

            outLog = stdOut + Environment.NewLine + stdErr;
            return proc.ExitCode == 0;
        }
    }
}
