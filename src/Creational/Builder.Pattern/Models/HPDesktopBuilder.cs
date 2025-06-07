using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Pattern.Models
{
    public class HPDesktopBuilder : DesktopBuilder
    {
        public override DesktopBuilder BuildGraphics()
        {
            desktop.Graphics = "Nvidia RTX 3050 6GB VRAM Graphics";
            return this;
        }

        public override DesktopBuilder BuildKeyboard()
        {
            desktop.Keyboard = "HP Keyboard";
            return this;
        }

        public override DesktopBuilder BuildMonitor()
        {
            desktop.Monitor = "HP Desktop";
            return this;
        }

        public override DesktopBuilder BuildMouse()
        {
            desktop.Mouse = "HP Mouse";
            return this;
        }

        public override DesktopBuilder BuildProcessor()
        {
            desktop.Processor = "Intel i5 13th gen processor";
            return this;
        }

        public override DesktopBuilder BuildRAM()
        {
            desktop.RAM = "16GB DDR5 RAM";
            return this;
        }

        public override DesktopBuilder BuildSpeaker()
        {
            desktop.Speaker = "Dolby ATOMS Speaker";
            return this;
        }
    }
}
