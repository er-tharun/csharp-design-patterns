using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Pattern.Models
{
    public abstract class DesktopBuilder
    {
        protected Desktop desktop = new Desktop();
        public abstract DesktopBuilder BuildProcessor();
        public abstract DesktopBuilder BuildRAM();
        public abstract DesktopBuilder BuildGraphics();
        public abstract DesktopBuilder BuildMonitor();
        public abstract DesktopBuilder BuildMouse();
        public abstract DesktopBuilder BuildKeyboard();
        public abstract DesktopBuilder BuildSpeaker();
        public Desktop GetDesktop()
        {
            return desktop;
        }
    }
}
