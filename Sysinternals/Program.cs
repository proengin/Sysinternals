using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysinternals
{
    class Program
    {
        static void Main(string[] args)
        {

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            var sysinternalKey = key.CreateSubKey("Sysinternals");
            var syncKey = sysinternalKey.CreateSubKey("Sync");
            syncKey.SetValue("EulaAccepted", 0x01, Microsoft.Win32.RegistryValueKind.DWord);
            syncKey.Close();
            sysinternalKey.Close();
            key.Close();
        }
    }
}
