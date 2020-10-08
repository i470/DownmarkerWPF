using MarkPad.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MarkPad.Core
{
    class Program
    {
        private const string Unique = "There can be only one MARKPAD!!! (We ignore crappy sequels here)";

        [STAThread]
        public static void Main()
        {
            var directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location);
            if (directoryName != null && Directory.GetCurrentDirectory() != directoryName)
                Directory.SetCurrentDirectory(directoryName);

            if (SingleInstance<App>.InitializeAsFirstInstance(Unique))
            {
                new App().Run();

                // Allow single instance code to perform cleanup operations
                SingleInstance<App>.Cleanup();
            }
        }
    }
}
