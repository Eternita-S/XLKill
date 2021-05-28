using Dalamud.Game.Command;
using Dalamud.Plugin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLKill
{
    class XLKill : IDalamudPlugin
    {
        internal DalamudPluginInterface pi;

        public string Name => "XLKill";

        public void Dispose()
        {
            pi.CommandManager.RemoveHandler("/xlkill");
            pi.Dispose();
        }

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            pi = pluginInterface;
            pi.CommandManager.AddHandler("/xlkill", new CommandInfo(delegate 
            {
                Process.GetCurrentProcess().Kill();
            }));
        }
    }
}
