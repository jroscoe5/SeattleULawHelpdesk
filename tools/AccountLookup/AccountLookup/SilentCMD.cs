using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLookup
{
    static class SilentCMD
    {
        public static void NetUserDomainLookup(string username)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C net user " + username; //+ " /domain";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                StreamReader reader = process.StandardOutput;

                var raw = reader.ReadToEnd();

                process.WaitForExit();

                LookupResult result = new LookupResult(raw);
            }
        }
    }
}
